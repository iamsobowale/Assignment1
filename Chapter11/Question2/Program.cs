using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Anwser();
        }
         public static void Anwser()
        {
            Random rand =new Random();
            int num= rand.Next(100,200);
            Console.WriteLine(num);
        }
    }
}
