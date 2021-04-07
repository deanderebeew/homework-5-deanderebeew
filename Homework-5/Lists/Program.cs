using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteItems = new List<string>();
            string answer;

            do
            {

                Console.WriteLine("What is your favorite thing that you would like to add to this list? >>");
                answer = Console.ReadLine();
                favoriteItems.Add(answer);

                Console.WriteLine("Do you have another thing to add? Yes or No??");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            Console.WriteLine("\n1) from the top to the bottom");
            foreach (string item in favoriteItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n2) in reverse order");
            for (int i = favoriteItems.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(favoriteItems[i]);
            }

            Console.WriteLine("\n3) output every other entry in the list");
            for (int i = 0; i < favoriteItems.Count; i+=2)
            {
                Console.WriteLine(favoriteItems[i]);
            }
        }
    }
}
