using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static int textnavpaku(String str)
    {

        string world = "";
        for(int i = str.Length-1; i > -1; i--)
        { world += str[i];}
        Console.WriteLine("перевернуте речення:"+world);
        return 0;
    }



    static int countnum(String str)
   {
        int s = 0;
        int h = 0;
        int r=0;int e =str.Length;
        char f;
            int k=0;
        for (int i = 0; i < str.Length; i++)
        {
            
        
            if (i != e - 1)
            {
                if (str[i] == '.' || str[i] == ',') { i++; r++; continue; }
            }

         if (char.IsNumber(str[i]))
          {
              h++;
          }
          f = str[i];
          if (char.IsNumber(str[i]) && i+1!=e){
          if (char.IsNumber(str[i + 1])){ continue; }k++; 
               
              }



          if(i == e - 1){
              if (char.IsNumber(str[i - 2]) && (str[i - 1]) == ',' && (str[i - 1]) == '.' && char.IsNumber(str[i])) { continue; }
                  if (!char.IsNumber(str[i - 1]) && char.IsNumber(str[i])) { k++;}
          }


      }

        if (k == 0) { for (int i = 0; i < str.Length; i++) 
            {
                if (char.IsNumber(str[i])) { s ++; }

            } 
        
        if (s == str.Length) { k = 1; }
        
        
        
        
        
        }

           Console.WriteLine("К-сть чисел у слові: чисел" + k);
        return 0;
    }
    static void Main(string[] args)
        
    {int swfor;
    menu:
        Console.WriteLine("\nМеню:\n1. інвертує рядок, подаючи його у зворотному вигляді;\n2. підраховує кількість чисел у тексті.");
        Console.Write("\nВаш вибір: ");
         swfor =int.Parse(Console.ReadLine());
        Console.WriteLine("");
        switch (swfor)
        {
           
            
            
            case 1: { Console.Write("\nВведіть текст: "); string str = Console.ReadLine(); textnavpaku(str); break; }
            case 2: {pomulka:
                    Console.WriteLine("Введіть текст: ");
        string str = Console.ReadLine();

        if (str[0] == '.' || str[0] == ',') { Console.WriteLine("у вас текст починаеться з точки чи з коми.\n спробуйте наступного разу не допустити ц1е1 помилки тому що код не буде коректно працювати.\n"); goto pomulka;}
        countnum(str);  break; }


            
            default: {  goto menu; }
        }

        
    }
}