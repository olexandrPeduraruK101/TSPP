using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2zvd5
{
    static class Program
    {
        static public double random(int n, int m)
        {
            int[,] f;
            f = new int[n, m];


            Random random = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    f[i, j] = random.Next(-100, 100);



            




            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            { // cukl dlya pokazu masuvu u vudi matruci
                for (int j = 0; j < m; j++)
                    Console.Write("f[" + i + "][" + j + "]=" + f[i, j] + "\t"); Console.Write("\n");
            }


            int k = 0;
            double l = 0;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (f[i, j] < 0)
                    {
                        l += f[i, j]; k++;
                    }
                }
            }



            if (k == 0) { Console.WriteLine("\nу цьому масив1 немае відемних значеннь"); }
            else { Console.Write("\nСума в1демних значень =" + l + "\n к-сть в1демних значень: " + k + "\n"); }





            return n;
        }

        static public double Example(int n, int m)
        {


            int[,] flou; 
                flou = new int[n,m];



            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            {//dlya vvodu masuva z klaviaturu
                for (int j = 0; j < m; j++)
                {
                    Console.Write("flou [" + i + "][" + j + "] = ");
                    flou[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < n; i++)
            { // cukl dlya pokazu masuvu u vudi matruci
                for (int j = 0; j < m; j++)
                    Console.Write("flou[" + i + "][" + j + "]=" + flou[i,j] + "\t"); Console.Write("\n");
            }


            int k = 0;
            double l = 0;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++){
                    if (flou[i, j] < 0)
                    {
                        l += flou[i, j]; k++;
                    }
                }
            }



                    if (k == 0) { Console.WriteLine("\nу цьому масив1 немае відемних значеннь"); }
            else { Console.Write("\nСума в1демних значень =" + l + "\n к-сть в1демних значень: " + k); }


            return n; 
        }
 
        //_________________________________________________________________________________________________________________________________________________________________________
        static void Main(string[] args)
        {
            int m;
            int n;
        metka:
            Console.WriteLine("Введ1ть к-сть рядк1в елемнтыв масиву n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введ1ть к-сть рядк1в елемнтыв масиву m: ");
            m = int.Parse(Console.ReadLine());

            if (n < 3) { Console.WriteLine("У вас значення менше 2. Ведіть 1нше щоб завдання добре працювало :)\n"); goto metka; }
            

        caseh:
            int casenum;
            Console.WriteLine("\n\nМеню:\n\n1. Виконати завдання за допомогою клав1атури.\n2. Виконати завдання за допомогою рандом1затора");
            Console.Write("\n\n\tВаш виб1р: ");
            casenum = int.Parse(Console.ReadLine());

            switch (casenum)
            {
                case 1: { Example(n,m); break;}
                    case 2:{ random(n, m);break;}
                
                default: { Console.WriteLine("Нажаль такого вар1анта в меню не має. Спробуйте ще раз :)\n\n\n"); goto caseh; }
            }

        }
    }
}