public class Breathing : Activity
{
    private static readonly object ConsoleWriterLock = new Object();
    public override void Display()
    {
        Console.Clear();
        base.Display();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out very slowly. "+
        "Clear your mind and focus on your breathing.");
    }
    public int GetRounds(int time)
    {
        int round = 0;
        int roundLength = 100;
        // int sessionDuration = SessionLength();
        while(roundLength > 10)
        {
            round ++;
            roundLength = time / round;
        }
        return round;
    }
    public void BreatheIn(int time)
    {
        Console.Clear();
        int startingTime = time;
        for (int i = startingTime; i >= 0; i--)
        {
            Console.SetCursorPosition(0,0);
            Console.Write($"\rBreathe in...{i}");
            Thread.Sleep(1000);
        }
    }
        public void BreatheOut(int time)
    {
        Console.Clear();
        int startingTime = time;
        for (int i = startingTime; i >= 0; i--)
        {
            Console.SetCursorPosition(0,0);
            Console.Write($"\rBreathe out...{i}");
            Thread.Sleep(1000);
        }
    }
    public void BreatheInAnimation(int time)
    {
        for (int i = 0; i < 4; i++)
        {
            if(i==0)
            {
                Console.SetCursorPosition(0,(4-i));
                Console.Write("\r↑↑↑↑↑↑↑↑");
                Thread.Sleep(time/4);
            }
            else
            {
                Console.SetCursorPosition(0,(5-i));
                Console.Write("\r        ");
                Console.SetCursorPosition(0,(4-i));
                Console.Write("\r↑↑↑↑↑↑↑↑");      
                Thread.Sleep(time/4);
            }
        }
    }
    public void BreatheOutAnimation(int time)
    {
        for (int i = 0; i < 4; i++)
        {
            if(i==0)
            {
                Console.SetCursorPosition(0,(1+i));
                Console.Write("\r↓↓↓↓↓↓↓↓");
                Thread.Sleep(time/4);
            }
            else
            {
                Console.SetCursorPosition(0,(0+i));
                Console.Write("        ");
                Console.SetCursorPosition(0,(1+i));
                Console.Write("\r↓↓↓↓↓↓↓↓");
                Thread.Sleep(time/4);
            }
        }        
    }
    public void BreatheInOut()
    {

        Display();
        int time = SessionLength();
        int rounds = GetRounds(time);
        int secondsPerRound = time/rounds;
        Console.WriteLine("Loading Activity");
        Animation();
        Console.Clear();
        Thread.Sleep(500);
        for (int i = 0; i < rounds; i++)
        {
            lock(ConsoleWriterLock)
            {
                // Console.Clear();
                Thread.Sleep(100);
                Thread breatheIn = new Thread(() => BreatheIn((secondsPerRound/2)-1));
                breatheIn.Priority = ThreadPriority.Highest;
                Thread breatheInAnimation = new Thread(() => BreatheInAnimation(((secondsPerRound*1000)/2)-1));
                breatheInAnimation.Priority = ThreadPriority.AboveNormal;
                breatheIn.Start();
                Thread.Sleep(50);
                breatheInAnimation.Start();
                Thread breatheOut = new Thread(() => BreatheOut((secondsPerRound/2)+1));
                breatheOut.Priority = ThreadPriority.Highest;
                Thread breatheOutAnimation = new Thread(() => BreatheOutAnimation(((secondsPerRound*1000)/2)+1));
                breatheOutAnimation.Priority = ThreadPriority.AboveNormal;
                breatheIn.Join();
                breatheInAnimation.Join();
                Thread.Sleep(100);
                breatheOut.Start();
                Thread.Sleep(50);
                breatheOutAnimation.Start();
                breatheOut.Join();
                breatheOutAnimation.Join();
                // Thread.Sleep(100);
            }
            // BreatheOutAnimation((time*1000)/rounds);
        }    
    }
}
//   -------------------------------
//  |        CODE GRAVEYARD         |
//   -------------------------------
//                -|-
//                 |
//             .-'~~~`-.
//           .'         `.
//           |  R  I  P  |
//           |           |
//           |           |
//         \\|           |//
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                // Task breatheInThread = Task.Factory.StartNew(() => BreatheIn(secondsPerRound));
                // Task breatheAnimateThread = Task.Factory.StartNew(()=> BreatheInAnimation((secondsPerRound*1000)));
                // Task.WaitAll(breatheInThread, breatheAnimateThread);
                // Task breatheOutThread = Task.Factory.StartNew(() => BreatheOut(secondsPerRound));
                // Task breatheOutAnimateThread = Task.Factory.StartNew(() => BreatheOutAnimation((secondsPerRound*1000)));
                // Task.WaitAll(breatheOutThread, breatheOutAnimateThread);
                // Console.Clear();
            // breatheInThread.Start();
            // breatheAnimateThread.Start();
            // breatheInThread.Join();
            // breatheAnimateThread.Join();
            // if(i==0)
            // {
            //     // BreatheIn();
            //     Console.Write("\r\n\n\n");
            //     Console.WriteLine("\r↑↑↑↑↑↑↑↑");
            //     Thread.Sleep(time/4);
            // }
            // else if(i==1)
            // {
            //     // BreatheIn();
            //     Console.Write("\r\n\n");
            //     Console.WriteLine("\r↑↑↑↑↑↑↑↑");
            //     Console.Write("\r\n");
            //     Thread.Sleep(time/4);
            // }
            // else if(i==2)
            // {
            //     // BreatheIn();
            //     Console.Write("\r\n");
            //     Console.WriteLine("\r↑↑↑↑↑↑↑↑");
            //     Console.Write("\r\n\n");
            //     Thread.Sleep(time/4);                
            // }
            // else
            // {
            //     // BreatheIn();
            //     Console.WriteLine("\r↑↑↑↑↑↑↑↑");
            //     Console.Write("\r\n\n\n");
            //     Thread.Sleep(time/4);               
            // }
            // if(i==0)
            // {
            //     BreatheOut();
            //     Console.WriteLine("↓↓↓↓↓↓↓↓");
            //     Console.Write("\n\n\n");
            //     Thread.Sleep(time/4);
            // }
            // else if(i==1)
            // {
            //     BreatheOut();
            //     Console.Write("\n");
            //     Console.WriteLine("↓↓↓↓↓↓↓↓");
            //     Console.Write("\n\n");
            //     Thread.Sleep(time/4);
            // }
            // else if(i==2)
            // {
            //     BreatheOut();
            //     Console.Write("\n\n");
            //     Console.WriteLine("↓↓↓↓↓↓↓↓");
            //     Console.Write("\n");
            //     Thread.Sleep(time/4);                
            // }
            // else
            // {
            //     BreatheOut();
            //     Console.Write("\n\n\n");
            //     Console.WriteLine("↓↓↓↓↓↓↓↓");
            //     Thread.Sleep(time/4);               
            // }