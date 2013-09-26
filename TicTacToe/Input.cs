using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Input
    {
        private Cursor cursor;
        //private Board board;
        public Input()
        {
            //board = new Board();
            cursor = new Cursor();

        }

        public void Move()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)     // Uppil flyttar markören ett steg upp
                    cursor.MoveUp();
                else if (key.Key == ConsoleKey.DownArrow)   // Nerpil flyttar markören ett steg ner 
                    cursor.MoveDown();
                else if (key.Key == ConsoleKey.LeftArrow)   // Vänsterpil flyttar markören ett steg åt vänster
                    cursor.MoveLeft();
                else if (key.Key == ConsoleKey.RightArrow)  // Högerpil flyttar markören ett steg åt höger
                    cursor.MoveRight();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    /*
                    if (board.GetValue(cursor.Xpos, cursor.Ypos) == 0)
                    {
              
                    }
                     */
                }

            }

        }
    }
}
