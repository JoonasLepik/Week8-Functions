using System;

namespace FunctionsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coulurs = { "red", "blue", "green", };
            string[] moreColors = { "yellow", "pink", "beige", "purple" };
            PickRandomColor(coulurs);
            PickRandomColor(moreColors);

        }
        private static void PickRandomColor (string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine(someArray[randomIndex]);
        }
    }
}
