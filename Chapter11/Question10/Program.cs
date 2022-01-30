using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Anwser();
        }
        public static void Anwser()
       {
           var str="23 65 54 8 7";
           int re=0;
            string[] sep=str.Split(" ");
           for (var i = 0; i < sep.Length; i++)
           {
               re+=int.Parse(sep[i]);
           }
           Console.WriteLine(re);
       } 
    }
}
