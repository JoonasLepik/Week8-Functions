using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname:");
            string userName = Console.ReadLine();           
            Console.WriteLine("Enter Year Of Birth:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your lastname:");
            string lastName = Console.ReadLine();
            //lisa perekonnanime
            Greetings(userName,userAge,lastName);
        }
        private static void Greetings(string someString, int someInt, string lastString)
        {
            //lisa perekonnanime
            Console.WriteLine($"Hi there, {someString} {lastString}!");
            Console.WriteLine($"You are {2021 - someInt} years old.");
        }
    }
}