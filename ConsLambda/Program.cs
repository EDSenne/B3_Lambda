using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int> { 12, 16, 17, 28 };
            int oddLocation = integers.FindIndex(i => i % 2 != 0);
            Console.WriteLine($"Odd number found on position {oddLocation}");   
            Console.ReadKey();
        }
    }
}
