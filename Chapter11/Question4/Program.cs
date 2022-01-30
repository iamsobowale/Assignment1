using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Anwser();
        }
         public static void Anwser()
        {
            int startTime = Environment.TickCount;
           int seconds= startTime/1000;
           var min=seconds/60;
           var hours= min/60;
           var days= hours/24;
           Console.WriteLine($"The Seconds gone is {seconds}\n And min is {min}\n Hours is {hours}\n Days is {days}");
        }
    }
}
