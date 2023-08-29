public class Board
{
    // int[,] _board = {{1,1,1},{1,1,1}};
    int[,] _board = new int[20, 20];

    public Board()
    {

    }

    public void SetUp()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                _board[i , j] = 0;
            }
        }
    }


}