using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WindowHeight = 15;
            Console.WindowWidth = 15;
            Input input = new Input(); 
            while (true)
            {
                input.Move();
            }
        }
    }
}
