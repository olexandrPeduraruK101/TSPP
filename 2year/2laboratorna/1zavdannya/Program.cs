using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static int Non(int f)
        {

            switch (f)
            {
                case 1:
                    {  Console.WriteLine("Червоний"); break; }
                    
                case 2:
                    { Console.WriteLine("Помаранчевий"); break; }

                case 3:
                    { Console.WriteLine("Жовтий");break; }
                    
                case 4:
                    
                    { Console.WriteLine("Зелений"); break; }

                case 5:
                    
                    { Console.WriteLine("Блакитний"); break; }

                case 6:
                    
                    { Console.WriteLine("Син1й"); break; }

                case 7:
                    
                    { Console.WriteLine("Фіолетовий"); break; }

                default:
                    { Console.WriteLine("нажаль такого номера у код1 немає"); break; }


            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("ВВЕД1ТЬ НОМЕР КОЛЬОРУ: ");
            
             int f = int.Parse(Console.ReadLine());
           Non(f);
        }
    }
   
 }