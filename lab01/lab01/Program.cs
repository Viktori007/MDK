using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a=-45;
            double a = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vvvvvvvv");
            Console.WriteLine("abc "+Math.Abs(c));
            Console.WriteLine("max " + Math.Max(a,c));
            Console.WriteLine("sqrt " + Math.Round(Math.Sqrt(a)));
            Console.WriteLine("Truncate " + Math.Truncate(a));

            Console.WriteLine(Math.Round( Math.Exp(a)+ Math.Exp(-a)/2));

        }
    }
}
