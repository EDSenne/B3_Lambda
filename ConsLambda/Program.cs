using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        delegate long multi(int x, int y, int z);
        static void Main(string[] args)
        {
            multi multiply = (x, y, z) => x * y * z;
            Console.WriteLine(multiply(2,3,4));    // Outputs 24
            Console.ReadKey();
        }
    }
}
