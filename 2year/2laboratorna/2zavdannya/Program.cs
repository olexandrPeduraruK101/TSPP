using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2zavd2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("\nLAboratorna 2 zavd 2\n");
            Console.WriteLine("variant 12\n\n\n\nMenu:\n\n1. Виконати завдання передумовою\n2. Виконати завдання п1сляумови\n");
            Console.WriteLine("\nВед1ть: \n");
            string S1 = Console.ReadLine();
            k = int.Parse(S1);
           
            switch (k)
            {
                case 1: {
                        float x = 0;
                        int max = 6;
                        float dx = 0.5f;
                        while (x <= max)
                        {
                            float y = 1 / (1 - (float)Math.Sqrt(x));
                            if (x == 1)
                            {Console.WriteLine("\n x = " + x);
                                Console.WriteLine("вiдбулося дiлення на = 0 \n");
                            }
                            else
                            {
                                Console.WriteLine("\n x = " + x);
                                Console.WriteLine("функцiя y = " + Math.Round(y,3));
                            }

                            x += dx;


                        }break;
                    }
                case 2:
                    {
                        float x = 0;
                        int max = 6;
                        float dx = 0.5f;
                        do
                        {
                            float y = 1 / (1 - (float)Math.Sqrt(x));
                            if (x == 1)
                            {
                                Console.WriteLine("\n x = " + x);
                                Console.WriteLine("вiдбулося дiлення на = 0 \n");
                            }
                            else
                            {
                                Console.WriteLine("\n x = " + x);
                                Console.WriteLine("функцiя y = " + Math.Round(y, 3));
                            }

                            x += dx;


                        }while (x <= max);break;

                    }
                default: { Console.WriteLine("Такого числа в меню немає");break; }
                    }
            }

}
}
           