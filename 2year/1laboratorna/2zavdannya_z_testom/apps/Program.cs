
using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public double Example(int x)
        {

            double y = Math.Pow(x, 3) - 4 * Math.Pow(x, 2) - 5 * x + 9 + Math.Cos(x);
            Console.WriteLine(" y = " + x.ToString() + "^3 - 4 * " +  x.ToString() + "^2 - 5 * " + x.ToString() + " + 9 + cos" + x.ToString());
            Console.WriteLine("\n y = " + y.ToString());
            return y;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введiть X");
            string S1 = Console.ReadLine();
            int x = int.Parse(S1);
            Example(x);
            Console.ReadLine();

        }
    }
}