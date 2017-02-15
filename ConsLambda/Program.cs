using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        delegate int lambda(int input);
        static void Main(string[] args)
        {
            lambda addOne = x => x + 1;
            Console.WriteLine(addOne(1));

            Console.ReadKey();
        }
    }
}
