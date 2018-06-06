using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i < 7; i++) {
                for (int a = 7; a > i; a--) {
                    Console.Write(" ");
                }
                for (int b = 0; b<i*2+1; b++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }  

        }
    }
}
