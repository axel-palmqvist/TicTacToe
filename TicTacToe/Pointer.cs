using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    class Pointer
    {
        public int state;

        public Pointer()
        {
            state = 0;
        }

        public void setValue(int value)
        {
            state = value;
        }

        public int GetValue()
        {
            return state;
        }
    }
}
