using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        delegate string lambda(double input);
        static void Main(string[] args)
        {
            lambda createCalculateMessage = x => $"{x} x 5 + 2 = {x * 5 + 2}";
            Console.WriteLine(createCalculateMessage(10));

            Console.ReadKey();
        }
    }
}
