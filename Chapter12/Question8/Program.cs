using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace Chapter12
{
    public class Question8
    {
        
        static void Main(string[] args)
        {    
            ReadFile();
        }
        public string file=@"C:\Users\user\Desktop\c#\Chapter122\Chapter12";
        public static string ReadFile()
        {
            string file=@"C:\Users\user\Desktop\c#\Chapter122\Chapter12";
            try
            {
            if (File.Exists(file))
            {
                List<string> sen =File.ReadAllLines(file).ToList();
                sen.Add("sd dsfg dfg sdfg ");
                File.WriteAllLines(file, sen);
                if (sen.Count==0)
                {
                    throw new Exception("File Empty");
                }
                 else
                {
                    foreach (var item in sen)
                    {
                        return sen.ToString(); 
                    }
                }
            } 
            else
            {
                string path =@"C:\Users\user\Desktop\c#\Chapter122\Chapter12";
                Directory.CreateDirectory(path);

                string fileName="fileName";
                string fullPath=Path.Combine(path, fileName);
                 File.Create(fullPath);
            }  
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
