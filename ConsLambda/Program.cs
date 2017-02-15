using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        delegate double noparams();
        static void Main(string[] args)
        {
            noparams taxRate = () => 33.5;
            Console.WriteLine($"Taxrate: {taxRate()}%");

            Console.ReadKey();
        }
    }
}
