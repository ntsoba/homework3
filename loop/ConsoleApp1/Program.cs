using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string output = "";
                for (int j = 0; j < i; j++)
                {
                    output += i;
                }
                Console.WriteLine(output);
            }Console.ReadKey();
        }
    }
}
