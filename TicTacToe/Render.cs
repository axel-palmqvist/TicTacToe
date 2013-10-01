using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Render
    {
        public Render()
        {

        }

        public void draw(Board aBoard)
        {
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                for (int y = 0; y < Console.WindowHeight; y++)
                {
                    if (aBoard.GetValue(x, y) == 1)
                    {
                        for (int i = x; i < x + 5; i++)
                        {
                            for (int j = y; j < y + 5; j++)
                            {
                                Console.SetCursorPosition(i, j);
                                Console.Write("X");
                            }
                        }
                    }
                    else if (aBoard.GetValue(x, y) == 2)
                    {
                        for (int i = x; i < x + 5; i++)
                        {
                            for (int j = y; j < y + 5; j++)
                            {
                                Console.SetCursorPosition(i, j);
                                Console.Write("O");
                            }
                        }
                    }
                }
            }
        }
    }
}
