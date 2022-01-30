using System;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
               while (true)
               {
                    Console.Clear();
                Console.WriteLine("Calculate the area of a triangle by given:");
                Console.WriteLine("1.Three side lengths.");
                Console.WriteLine("2.Length of one side and it's altitude.");
                Console.WriteLine("3.Length of two sides and the angle between them.");
                Console.WriteLine("4.Exit.");
                Console.Write("Enter choice from 1 to 4: ");
                int num=int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                    byThreeSides(); 
                    break;
                    case 2: 
                    bySideAltitude(); 
                    break;
                    case 3: 
                    byTwoSidesAngle(); 
                    break;
                }
               }   
        }
        public static void byThreeSides()
        {
            Console.Write("Enter side a ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            Console.WriteLine($"{(double)(Math.Sqrt(p * (p - a) * (p - b) * (p - c)))}");
            Console.ReadLine();
        }

        public static void bySideAltitude()
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter h(a): ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(a * b) / 2}");
            Console.ReadLine();
        }

        public static void byTwoSidesAngle()
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter sine: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(a * b * Math.Sin(c)) / 2}");
            Console.ReadLine();
        }
    }
}
