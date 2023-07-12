using System.Media;
public class BasicSynth
{
    const int _sampleRate = 44100;
    const short _bitsPerSample = 16;

    public void BS_KeyDown()
    {
        short[] wave = new short[_sampleRate];
        byte[] binaryWave = new byte[_sampleRate * sizeof(short)];
        float frequency = 440f;
        for (int i = 0; i < _sampleRate; i++)
        {
            wave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / _sampleRate) * i));
        }
        Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
        using (MemoryStream memoryStream = new MemoryStream())
        using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
        {
            short blockAlign = _bitsPerSample / 8;
            int subChunkTwoSize = _sampleRate * blockAlign;
            binaryWriter.Write(new[] {'R','I','F','F'});
            binaryWriter.Write(36 + subChunkTwoSize);
            binaryWriter.Write(new[] {'W','A','V','E','F','O','R','M'});
            binaryWriter.Write(16);
            binaryWriter.Write((short)1);
            binaryWriter.Write((short)1);
            binaryWriter.Write(_sampleRate);
            binaryWriter.Write(_sampleRate * blockAlign);
            binaryWriter.Write(blockAlign);
            binaryWriter.Write(_bitsPerSample);
            binaryWriter.Write(new[] {'d','a','t','a'});
            binaryWriter.Write(subChunkTwoSize);
            binaryWriter.Write(binaryWave);
            // SoundPlayer sp = new SoundPlayer();
            memoryStream.Position = 0;
            new SoundPlayer(memoryStream).Play();

        }
    }
}