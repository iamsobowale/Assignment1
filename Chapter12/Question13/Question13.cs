using System;
using System.IO;
using System.Net;

namespace Chapter12
{
    public class Question13
    {
        WebClient Client = new WebClient();
        public void Internet()
        {
             try 
            {
                Client.DownloadFile("http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.bmp", @"C:\Users\user\Desktop\c#\Chapter122\image.bmp");            
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}