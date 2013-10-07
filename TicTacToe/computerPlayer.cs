using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class computerPlayer: Player
    {
        int playerId = 1;
        public computerPlayer(Board board, int id, Cursor cursor): base(board, id, cursor)
        {
        }
        //Does a standard strategy, that works, not pretty but it works... Check wikipedia for easy follow.
        public override void Move()
        {
            //Step one!  Lets win if possible.
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board.GetValue(1 + x * 5, 1 + y * 3)==0)
                    {
                        if (checkVictory(1 + x * 5, 1 + y * 3,id))
                        {
                            board.setValue(id, 1 + x * 5, 1 + y * 3);
                            render.draw(board);
                            return;
                        }
                    }
                }
            }
            //Step two, else we block the motherf**er
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board.GetValue(1 + x * 5, 1 + y * 3) == 0)
                    {
                        if (checkVictory(1 + x * 5, 1 + y * 3, playerId))
                        {
                            board.setValue(id, 1 + x * 5, 1 + y * 3);
                            render.draw(board);
                            return;
                        }
                    }
                }
            }
            //Step three, lets fork the motherfu**er
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board.GetValue(1 + x * 5, 1 + y * 3) == 0)
                    {
                        if (fork(1 + x * 5, 1 + y * 3, id))
                        {
                            board.setValue(id, 1 + x * 5, 1 + y * 3);
                            render.draw(board);
                            return;
                        }
                    }
                }
            }
            //Step four, well, why not block the kind gentlemans fork?
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board.GetValue(1 + x * 5, 1 + y * 3) == 0)
                    {
                        if (fork(1 + x * 5, 1 + y * 3, playerId))
                        {
                            //Step 4.1, block it by creating a win opportunity. 
                            for (int xx = 0; xx < 3; xx++)
                            {
                                for (int yy = 0; yy < 3; yy++)
                                {
                                    if (board.GetValue(1 + xx * 5, 1 + yy * 3) == 0)
                                    {
                                        if (twoinarow(1 + xx * 5, 1 + yy * 3, id))
                                        {
                                            board.setValue(id, 1 + xx * 5, 1 + yy * 3);
                                            render.draw(board);
                                            return;
                                        }
                                    }
                                }
                            }
                            //Step 4.2, Or just block?
                            board.setValue(id, 1 + x * 5, 1 + y * 3);
                            render.draw(board);
                            return;
                        }
                    }
                }
            }
            //Step 5, lets go to center and place our piece.
            if (board.GetValue(6, 4) == 0)
            {
                board.setValue(id,6,4);
                return;
            }
            // Step 6, lets put it in the opposite corner. 
            else if(board.GetValue(1,1) == playerId && board.GetValue(11,7) == 0)
            {
                board.setValue(id, 11, 7);
            }
            //see above comment.
            else if(board.GetValue(11,1) == playerId && board.GetValue(1,7) == 0)
            {
                board.setValue(id, 1, 7);
            }
            //see above comment.
            else if(board.GetValue(11,7) == playerId && board.GetValue(1,1) == 0)
            {
                board.setValue(id, 1, 1);
            }
            //see above comment.
            else if(board.GetValue(1,7) == playerId && board.GetValue(11,1) == 0)
            {
                board.setValue(id, 11, 1);
            }
            //Step 7, WHY NOT EMPTY CORNER?!
            else if (board.GetValue(1, 1) == 0)
            {
                board.setValue(id, 1, 1);
            }
            //see above comment.
            else if (board.GetValue(11, 1) == 0)
            {
                board.setValue(id, 11, 1);
            }
            //see above comment.
            else if (board.GetValue(1, 7) == 0)
            {
                board.setValue(id, 1, 7);
            }
            //see above comment.
            else if (board.GetValue(11, 7) == 0)
            {
                board.setValue(id, 11, 7);
            }
            //Step 8, why not just in the middle of a side? mmm, pork.
            else if (board.GetValue(6, 1) == 0)
            {
                board.setValue(id, 6, 1);
            }
            //see above comment.
            else if (board.GetValue(11, 4) == 0)
            {
                board.setValue(id, 11, 4);
            }
            //see above comment.
            else if (board.GetValue(6, 7) == 0)
            {
                board.setValue(id, 6, 7);
            }
            //see above comment.
            else if (board.GetValue(1, 4) == 0)
            {
                board.setValue(id, 1, 4);
            }
            /*
             |1,1|6,1|11,1|
            ---------------
             |1,4|6,4|11,4|
             --------------
             |1,7|6,7|11,7|
            */

            render.draw(board);
        }
        //Kolla om det är vinst när datorn lägger ner.
        public bool checkVictory(int x,int y, int tempid)
        {
            board.setValue(tempid, x, y);
            bool temp = false;
        //Ruta 1 2 3 = Victory?
            if (board.GetValue(1, 1) == tempid && board.GetValue(6, 1) == tempid && board.GetValue(11, 1) == tempid)
            {
                temp = true;
            }
            //Check if 3,4,5 = victory
            else if (board.GetValue(1, 4) == tempid && board.GetValue(6, 4) == tempid && board.GetValue(11, 4) == tempid)
            {
                temp = true;
            }
            //Check if 6,7,8 is = victory!
            else if (board.GetValue(1, 7) == tempid && board.GetValue(6, 7) == tempid && board.GetValue(11, 7) == tempid)
            {
                temp = true;
            }
            //Check if 1,3,6 is = Victory!
            else if (board.GetValue(1, 1) == tempid && board.GetValue(1, 4) == tempid && board.GetValue(1, 7) == tempid)
            {
                temp = true;
            }
            //Check if 2,4,8 is = Victory!
            else if (board.GetValue(6, 1) == tempid && board.GetValue(6, 4) == tempid && board.GetValue(6, 7) == tempid)
            {
                temp = true;
            }
            //Check if 3,6,9
            else if (board.GetValue(11, 1) == tempid && board.GetValue(11, 4) == tempid && board.GetValue(11, 7) == tempid)
            {
                temp = true;
            }
            //Check if 1,5,9 is victory!
            else if (board.GetValue(1, 1) == tempid && board.GetValue(6, 4) == tempid && board.GetValue(11, 7) == tempid)
            {
                temp = true;
            }
            //Check if 3,5,7 is victory!
            else if (board.GetValue(11, 1) == tempid && board.GetValue(6, 4) == tempid && board.GetValue(1, 7) == tempid)
            {
                temp = true;
            }
            else
            {
                temp = false;
            }
            board.setValue(0,x,y);
            return temp;
        }

        public bool fork(int XX, int YY, int tempid)
        {
            int temp = 0;
            board.setValue(tempid, XX , YY);
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board.GetValue(1 + x * 5, 1 + y * 3) == 0)
                    {
                        if (checkVictory(1 + x * 5, 1 + y * 3, tempid))
                        {
                            temp++;
                            
                        }
                    }
                }
            }

            board.setValue(0, XX, YY);
            return temp > 1 ? true : false;
        }
        public bool twoinarow(int XX, int YY, int tempid)
        {
            int temp = 0;
            board.setValue(tempid, XX, YY);
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (board.GetValue(1 + x * 5, 1 + y * 3) == 0)
                    {
                        if (checkVictory(1 + x * 5, 1 + y * 3, tempid))
                        {
                            temp++;

                        }
                    }
                }
            }
            board.setValue(0, XX, YY);
            return temp > 0 ? true : false;
        }
    }

}
