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
                        Fill(x,y,'X');
                    }
                    else if (aBoard.GetValue(x, y) == 2)
                    {
                        Fill(x, y, 'O');   
                    }
                }
            }

        }
        private void Fill(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

    }
}
