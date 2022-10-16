using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                int countofEmpty = 5 - i;//空白的長度
                int countoStar = i;//星號的長度

                string row = new string(' ',countofEmpty) + new string('*', countoStar);
                Console.WriteLine(row);
            }
        }
    }
}
