using System;
using System.Collections.Generic;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a list to hold the sorted arrays
            List<List<int>> listOfLists = new List<List<int>>();

            // Create a random number generator
            Random rand = new Random();

            // Generate 5 sorted arrays
            for (int i = 0; i < 5; i++)
            {
                // Generate a random length between 5 and 10
                int length = rand.Next(5, 11);

                // Generate a sorted array of random integers
                List<int> sortedArray = new List<int>();
                for (int j = 0; j < length; j++)
                {
                    sortedArray.Add(rand.Next(100));
                }
                sortedArray.Sort();

                // Append the sorted array to the list of lists
                listOfLists.Add(sortedArray);
            }

            Console.WriteLine($"Hello from AbstractFactoryDesignPattern..!! {Environment.NewLine}");

            // Print the list of lists
            foreach (var array in listOfLists)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
