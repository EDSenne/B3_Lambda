using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        public delegate double ConvertUnit(double value);

        public double CalToKj(double cal)
        {
            return cal * 4.814;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ConvertUnit cu = p.CalToKj;
            double calorie = 20;
            double kJ = cu(calorie);
            Console.WriteLine($"{calorie} cal = {Math.Round(kJ, 3)} kJ");

            Console.ReadKey();
        }
    }
}
