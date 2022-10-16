using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
              
            for (int j = 0; j <= (5 - (i + 1)); j++)
                {

                Console.Write(" ");

                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
