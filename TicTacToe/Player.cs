using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        private Cursor cursor;
        public Board board;
        public Render render;
        private bool turn { get; set; }

        private bool running { get; set; }
        public int id;

        public Player(Board board, int id, Cursor cursor)
        {
            this.id = id;
            this.board = board;
            this.cursor = cursor;
            render = new Render();
            turn = true;

            running = true;

        }
        private void winCalc()
        {
            for (int i = 1; i <= 2; i++)
            {
                if (board.GetValue(1, 1) == i && board.GetValue(6, 1) == i && board.GetValue(11, 1) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(1, 4) == i && board.GetValue(6, 4) == i && board.GetValue(11, 4) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(1, 7) == i && board.GetValue(6, 7) == i && board.GetValue(11, 7) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(1, 1) == i && board.GetValue(1, 4) == i && board.GetValue(1, 7) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(6, 1) == i && board.GetValue(6, 4) == i && board.GetValue(6, 7) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(11, 1) == i && board.GetValue(11, 4) == i && board.GetValue(11, 7) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(1, 1) == i && board.GetValue(6, 4) == i && board.GetValue(11, 7) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }
                else if (board.GetValue(11, 1) == i && board.GetValue(6, 4) == i && board.GetValue(1, 7) == i)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Tre i rad");
                }

            }
        }

        public virtual void Move()
        {
            bool finish = false;
            while (finish == false)
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



                        if (board.GetValue(cursor.mXpos, cursor.mYpos) == 0)
                        {

                            if (id == 1)
                            {
                                board.setValue(1, cursor.mXpos, cursor.mYpos);
                                cursor.mChar = 'X';
                            }
                            else
                            {
                                board.setValue(2, cursor.mXpos, cursor.mYpos);
                                cursor.mChar = 'X';
                            }
                            finish = true;
                        }
                    }
                    render.draw(board);
                    winCalc();

                    render.draw(board);
                }
            }
        }
    }
}
