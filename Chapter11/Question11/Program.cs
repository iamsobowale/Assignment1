using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Anwser();
        }
        public static void Anwser()
        {
            Random rand=new Random();
           string[] laudatoryStories= {"Now I feel better.", "I managed to change.", "It made some miracle.","I cant believe it", "but now I am feeling great.", "You should try it", "too. I am very satisfied"};
           string[] laudatoryPhrases= {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
           string[] firstName={"Dayan", "Stella", "Hellen", "Kate"};
           string[] lastName={"Johnson", "Peterson", "Charls"};
           string[] citie={"London", "Paris", "Berlin", "New York", "Madrid"};
           Console.WriteLine($"{firstName[rand.Next(0,firstName.Length)]} {lastName[rand.Next(0,lastName.Length)]} {laudatoryStories[rand.Next(0,laudatoryStories.Length)]} {laudatoryPhrases[rand.Next(0,laudatoryPhrases.Length)]} {citie[rand.Next(0,citie.Length)]} ");
        }
    }
}
