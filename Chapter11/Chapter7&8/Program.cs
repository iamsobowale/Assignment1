using System;

namespace CreatingAndUsingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name= "cat";
            for (int i = 0; i < 10; i++)
            {
                Cat cat =new Cat($"{name} {Sequence.NextValue()}");
                cat.sayMiau();
            }
        }
    }
}
