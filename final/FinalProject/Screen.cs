public class Screen
{
    int[,] _board = new int[22, 22];
    int _width = 24;
    int _height = 22;

    public Screen()
    {

    }

    public void SetUpScreen()
    {
        Console.Clear();

    }
    public void Border()
    {
        Console.Clear();
        for (int i = 0; i <= _height; i++)
        {
            if(i == 22)
            {
            Console.Write("|======================");
            Console.WriteLine("|");
            break;
            }
            else
            {
                
                Console.Write("|");
                // for (int k = 0; k < _board.GetLength(k); k++)
                // {
                    for (int j = 0; j < _board.GetLength(1); j++)
                    {
                        Console.Write(_board[i, j]);
                    }
                // }
                // foreach (int number in _board)
                // {
                //     int j = 0;
                //     Console.Write(_board[i, j]);
                //     j++;
                //     if(i != )
                // }
                // while(_board[0, 0] == i)
                // {
                //     int j = 0;
                //     Console.Write(_board[i, j]);
                //     j++;
                // }
                Console.SetCursorPosition(_width - 1, i);
                Console.WriteLine("|");
            }
        }
    }


    public void SetUp()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 22; j++)
            {
                _board[i , j] = 0;
            }
        }
    }
}