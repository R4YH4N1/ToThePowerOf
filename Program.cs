using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Input the number to be multiplied");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Input the number to multiply by");
            y = Convert.ToInt32(Console.ReadLine());

            int z = x * y;

            Console.WriteLine("Your answer is {0}", z);
            Console.ReadLine();

        }
    }
}
