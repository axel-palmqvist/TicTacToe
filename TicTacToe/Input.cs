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
        private Board board;
        private Render render;
        private Bot bot;
        private bool turn { get; set; }
        private bool running { get; set;}
        private int botMove { get; set; }

        public bool mbot { get; set; } 


        public Input()
        {
            Start();
        }
        private void Start()
        {
            Console.WriteLine("Vill du spela\nmot bot? J/N");
            string answer = Console.ReadLine();
            if (answer == "j")
            {
                mbot = true;
            }
            else
            {
                mbot = false;
            }
            board = new Board();
            cursor = new Cursor();
            render = new Render();
            bot = new Bot();
            turn = true;
            running = true;
            botMove = 1;
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
                        if (board.GetValue(cursor.mXpos, cursor.mYpos) == 0)
                        {

                            if (turn)
                            {
                                board.setValue(1, cursor.mXpos, cursor.mYpos);
                                turn = !turn;
                                cursor.mChar = 'O';
                                if (mbot)
                                {
                                    bot.Evaluate(board,botMove);
                                    board.setValue(2, bot.x, bot.y);

                                    turn = !turn;
                                    cursor.mChar = 'X';
                                    botMove = 2;
                                }
                            }
                            else
                            {   
                                board.setValue(2, cursor.mXpos, cursor.mYpos);
                                turn = !turn;
                                cursor.mChar = 'X';
                                botMove = 2;
                            }

                        }
                    }
                    render.draw(board);
                    winCalc();
                }
        }
    }
}
    
