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
            var filteredList = integers.Where(i => i > 15);
            foreach (int i in filteredList)
            {
                Console.WriteLine($"Number: {i}");
            }
            Console.ReadKey();
        }
    }
}
