using System;
namespace CreatingAndUsingObjects
{
    public class Cat
    {
       public string name;

        public Cat(string name)
        {
        this.name = name;
        }
        public void sayMiau()
        {
            Console.WriteLine($"{name}, Miauu");
        }    
   }
      }