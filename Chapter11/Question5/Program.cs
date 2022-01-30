using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Anwser();
        }
         public static void Anwser()
        {
            Console.WriteLine("Enter side A");
            var a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B");
            var b=int.Parse(Console.ReadLine());
            var raisetopow=Math.Pow(a,2);
            var raisetopow2=Math.Pow(a,2);
            var sqauare =Math.Sqrt(raisetopow+raisetopow2);
            Console.WriteLine(sqauare);
        }
    }
}
