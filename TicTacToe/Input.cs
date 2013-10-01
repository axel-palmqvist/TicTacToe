﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Input
    {
        private Cursor cursor;
        private Board board;
        private Render render;
        private bool turn { get; set; }
        private bool running { get; set;}

        public Input()
        {
            board = new Board();
            cursor = new Cursor();
            render = new Render();
            turn = true;
            running = true;

        }

        public void Move()
        {
            if (running)
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
                            if (turn)
                            {
                                board.setValue(1, cursor.mXpos, cursor.mYpos);
                                turn = !turn;
                            }
                            else
                            {
                                board.setValue(2, cursor.mXpos, cursor.mYpos);
                                turn = !turn;
                            }
                        }

                    }

                }

                for (int i = 1; i <= 2; i++)
                {
                    if (board.GetValue(1, 1) == i && board.GetValue(6, 1) == i && board.GetValue(11, 1) == i)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 14);
                        Console.WriteLine("Tre i rad");
                        running = false;
                    }


                }

                render.draw(board);
            }
        }
    }
}
