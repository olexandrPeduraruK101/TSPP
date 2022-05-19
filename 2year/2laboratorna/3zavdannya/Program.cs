using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba2zvd3
{
    static class Program
    {
        static public double Example(int n)
        {
            
            
            int[] a = new int[n];
            for (int i = 0; i < n; i++)// цикл для написання 
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            int k = 0;
            double l = 1;


            for (int i = 0; i < n; i++)//цикл для виконання множ в1демних значень
            { if (a[i] < 0) { l *= a[i];k++;}}

            int min = a[0];

            for (int i = 0;i < n; i++)//самий найменший масив
            { if (min > a[i]) { min = a[i]; }
            }

            int index = 0;//1ндекс м1н масива
            for (int i = 0; i < n; i++)
            {
                if (min == a[i]) { index = i;}
            }


            if(k == 0) { Console.WriteLine("\nу цьому масив1 немае відемних значеннь");}
            else { Console.Write("\nМножина в1демних чисел ="+ l +"\n");}

            

            double sum=0;
            if (n-1 == index) { Console.WriteLine("a[" + index + "] = " + min +" Цей масив сто1ть у самому к1нц1\n тому після нього 1нших елемент1в немае"); }
            else
            {
                for (int i = index + 1; i < n; i++) { sum = sum + a[i];}
                Console.WriteLine("Минимальний масив: a["+ index +"]=" + min);
                Console.WriteLine("Сума елемент1в масиву п1сля м1н значення: "+ sum);
            }

           


                return n;
        }


        //_________________________________________________________________________________________________________________________________________________________________________
        static public double random(int n) {
            int[] a = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)//random

            {
                a[i] = random.Next(-100, 100);
            }



            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }


            int k = 0;
            double l = 1;


            for (int i = 0; i < n; i++)//цикл для виконання множ в1демних значень
            { if (a[i] < 0) { l *= a[i]; k++; } }

            int min = a[0];

            for (int i = 0; i < n; i++)//самий найменший масив
            {
                if (min > a[i]) { min = a[i]; }
            }

            int index = 0;//1ндекс м1н масива
            for (int i = 0; i < n; i++)
            {
                if (min == a[i]) { index = i; }
            }


            if (k == 0) { Console.WriteLine("\nу цьому масив1 немае відемних значеннь"); }
            else { Console.Write("\nМножина в1демних чисел =" + l + "\n"); }



            double sum = 0;
            if (n - 1 == index) { Console.WriteLine("a[" + index + "] = " + min + " Цей масив сто1ть у самому к1нц1\n тому після нього 1нших елемент1в немае"); }
            else
            {
                for (int i = index + 1; i < n; i++) { sum = sum + a[i]; }
                Console.WriteLine("Минимальний масив: a[" + index + "]=" + min);
                Console.WriteLine("Сума елемент1в масиву п1сля м1н значення: " + sum);
            }



            return n;
        }
        //_________________________________________________________________________________________________________________________________________________________________________
        static void Main(string[] args)
        {
            int n;
            metka:
            Console.WriteLine("Введ1ть к-сть елемнтыв масиву: ");
            n = int.Parse(Console.ReadLine());

            if(n < 3) { Console.WriteLine("У вас значення менше 2. Ведіть 1нше щоб завдання добре працювало :)\n"); goto metka;}
            

            caseh:
            int casenum;
            Console.WriteLine("\n\nМеню:\n\n1. Виконати завдання за допомогою клав1атури.\n2. Виконати завдання за допомогою рандом1затора");
            Console.Write("\n\n\tВаш виб1р: ");
            casenum = int.Parse(Console.ReadLine());

            switch (casenum)
            {
                case 1: {Example(n); break; }
                    case 2: { random(n); break; }
                default: { Console.WriteLine("Нажаль такого вар1анта в меню не має. Спробуйте ще раз :)\n\n\n"); goto caseh;}
            }
                    

        }
    }
}