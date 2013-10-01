using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Cursor
    {
        // Medlemsvariabler
        private char mChar;
        public int mYpos { set; get; }
        public int mXpos { set; get; }

        // Konstukter 
        public Cursor()
        {
            mYpos = 1;
            mXpos = 1;



            // Sätter ut pekaren på en startposition
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(mXpos, mYpos);
            PrintPointer();
        }


        // Flyttar pekaren ett steg upp om den inte redan är längst upp
        public void MoveUp()
        {
            if (mYpos > 1)
            {
                RemovePointer();
                mYpos = mYpos - 3;
                PrintPointer();
            }
        }

        // Flyttar pekaren ett steg ner om den inte redan är längst ner
        public void MoveDown()
        {
            if (mYpos + 5 < Console.WindowHeight - 5)
            {
                RemovePointer();
                mYpos = mYpos + 3;
                PrintPointer();
            }
        }

        // Flyttar pekaren ett steg åt vänster om den inte redan är längst åt vänster
        public void MoveLeft()
        {
            if (mXpos > 1)
            {
                RemovePointer();
                mXpos = mXpos - 5;
                PrintPointer();
            }
        }

        // Flyttar pekaren ett steg åt höger om den inte redan är längst åt höger
        public void MoveRight()
        {
            if (mXpos + 2 < Console.WindowWidth - 4)
            {
                RemovePointer();
                mXpos = mXpos + 5;
                PrintPointer();
            }
        }

        // Skriver ut pekare
        public void PrintPointer()
        {
            Console.SetCursorPosition(mXpos, mYpos);
            Console.Write("x");
        }

        // Raderar pekare
        public void RemovePointer()
        {
            Console.SetCursorPosition(mXpos, mYpos);
            Console.Write(' ');
        }
    }
}
