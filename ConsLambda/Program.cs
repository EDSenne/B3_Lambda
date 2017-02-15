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
            noparams randomiser = () =>
            {
                int random = new Random().Next();
                Console.WriteLine($"Random number generated - {random}");
                return random;
            };
            randomiser();
            Console.ReadKey();
        }
    }
}
