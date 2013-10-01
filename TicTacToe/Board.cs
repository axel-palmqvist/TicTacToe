using System;


namespace TicTacToe
{

        public class Board
        {

            private Pointer[,] p = new Pointer[Console.WindowHeight, Console.WindowWidth];
<<<<<<< HEAD

            
=======
        
>>>>>>> c3f1b5ea050f0284e64bf9ba0c13ecb96e033688


            public Board()
            {
                FillBoard();
                BoardGraphics();
            }

            public void BoardGraphics()
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        draw(x * 5, y * 3);
                    }
                }
            }
            public void draw(int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("┌───┐");
                Console.SetCursorPosition(x, y + 1);
                Console.Write("│   │");
                Console.SetCursorPosition(x, y + 2);
                Console.Write("└───┘");
            }
            public void FillBoard()
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    for (int y = 0; y < Console.WindowHeight; y++)
                    {
                        p[x, y] = new Pointer();
                    }

                }
            }


            public void setValue(int value, int x, int y)
            {
                p[x, y].setValue(value);
            }

            public int GetValue(int x, int y)
            {
                return p[x, y].GetValue();
            }
        }
<<<<<<< HEAD
        }
=======
}
>>>>>>> c3f1b5ea050f0284e64bf9ba0c13ecb96e033688
    
