using System;
using System.IO;
namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro =new Program();
            pro.Processed();
        }
         public void Processed()
        {
            Console.WriteLine("Enter File Path");
            string path=Console.ReadLine();
            try
            {
                 string[] file= File.ReadAllLines(path);
                 foreach (var item in file)
                 {
                     Console.WriteLine(item);
                 }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{Console.WriteLine("Hello");}
        }
    }
}
