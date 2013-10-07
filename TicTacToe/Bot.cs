using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Bot
    {
        public int x { get; set; }
        public int y { get; set; }

        public Bot()
        {
            x = 0;
            y = 0;
 
        }            


        public void Evaluate(Board aboard, int move)
        {
            switch(move)
            {
                case 1:
            if (aboard.GetValue(6, 4) != 1)
            {
                x = 6;
                y = 4;
            }
            else
            {
                x = 1;                              
                y = 1;
                /*
                     1,1|6,1|11,1
                     1,4|6,4|11,4
                     1,7|6,7|11,7
                     */
            }
                    break;
                case 2:
                    for (int i = 1; i <= 2; i++)
                    {

                        if (aboard.GetValue(1, 1) == i && aboard.GetValue(1, 7) == i && aboard.GetValue(1, 4) == 0)
                        {
                            x = 1;
                            y = 4;
                            return;
                        }
                        else if (aboard.GetValue(1, 1) == i && aboard.GetValue(11, 1) == i && aboard.GetValue(6, 1) == 0)
                        {
                            x = 6;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(11, 7) == i && aboard.GetValue(11, 1) == i && aboard.GetValue(11, 4) == 0)
                        {
                            x = 11;
                            y = 4;
                            return;


                        }
                        else if (aboard.GetValue(1, 1) == i && aboard.GetValue(11, 7) == i && aboard.GetValue(6, 4) == 0)
                        {
                            x = 6;
                            y = 4;
                            return;

                        }
                        else if (aboard.GetValue(1, 7) == i && aboard.GetValue(11, 7) == i && aboard.GetValue(6, 7) == 0)
                        {
                            x = 6;
                            y = 7;
                            return;
                        }
                        else if (aboard.GetValue(1, 1) == i && aboard.GetValue(6, 1) == i && aboard.GetValue(11, 1) == 0)
                        {
                            x = 11;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(6, 1) == i && aboard.GetValue(11, 1) == i && aboard.GetValue(1, 1) == 0)
                        {
                            x = 1;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(11, 1) == i && aboard.GetValue(11, 4) == i && aboard.GetValue(11, 7) == 0)
                        {
                            x = 11;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(11, 4) == i && aboard.GetValue(11, 7) == i && aboard.GetValue(11, 1) == 0)
                        {
                            x = 11;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(6, 7) == i && aboard.GetValue(11, 7) == i && aboard.GetValue(1, 7) == 0)
                        {
                            x = 1;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(1, 7) == i && aboard.GetValue(6, 7) == i && aboard.GetValue(11, 7) == 0)
                        {
                            x = 11;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(1, 7) == i && aboard.GetValue(4, 1) == i && aboard.GetValue(1, 1) == 0)
                        {
                            x = 1;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(1, 4) == i && aboard.GetValue(1, 1) == i && aboard.GetValue(1, 7) == 0)
                        {
                            x = 1;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(1, 1) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(11, 7) == 0)
                        {
                            x = 11;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(6, 1) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(6, 7) == 0)
                        {
                            x = 6;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(11, 1) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(1, 7) == 0)
                        {
                            x = 1;
                            y = 7;
                            return;

                        }
                        else if (aboard.GetValue(11, 4) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(1, 4) == 0)
                        {
                            x = 1;
                            y = 4;
                            return;

                        }
                        else if (aboard.GetValue(11, 7) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(1, 1) == 0)
                        {
                            x = 1;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(6, 7) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(6, 1) == 0)
                        {
                            x = 6;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(1, 7) == i && aboard.GetValue(6,  4) == i && aboard.GetValue(11, 1) == 0)
                        {
                            x = 11;
                            y = 1;
                            return;

                        }
                        else if (aboard.GetValue(1, 4) == i && aboard.GetValue(6, 4) == i && aboard.GetValue(11, 4) == 0)
                        {
                            x = 11;
                            y = 4;
                            return;

                        }
                        else
                        {
                            for (int z = 1; z <= 11; z = z + 5)
                            {
                                for (int j = 1; j <= 7; j = j + 3)
                                {
                                    if (aboard.GetValue(z, j) == 0)
                                    {
                                        x = z;
                                        y = j;
                                        return; 
                                    }
                                }
                            }
 
                        }
                        
                    }
                    break;
            }
           
        }
    }
}                    /*
                     1,1|6,1|11,1
                     1,4|6,4|11,4
                     1,7|6,7|11,7
                     */