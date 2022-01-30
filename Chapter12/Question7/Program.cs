using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Anwser();
        }
        public static void Anwser()
        {
           Console.WriteLine("Input a number ");
          try
          {
                int num=int.Parse(Console.ReadLine());
            if (num<0)
            {
                Console.WriteLine("Invalid number!");
            }
            Console.WriteLine(Math.Sqrt(num));
          }
          catch (FormatException)
          {
            //   Console.WriteLine(e.Message);
              Console.WriteLine("Invalid input");
          }
          finally
          {
               Console.WriteLine("Good Bye!");
          }
        }
    }
}
