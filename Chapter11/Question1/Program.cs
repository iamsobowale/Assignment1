using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
             Anwser();
        }
         public static void Anwser()
        {
            Console.Write("Enter a year: ");
            int num=int.Parse(Console.ReadLine());
            var num2 =DateTime.IsLeapYear(num);
            if (num2==true)
            {
                Console.WriteLine("Is a leap year");
            }
            else
            {
                Console.WriteLine("Is not a leap year");
            }
          
        }  
    }
}
