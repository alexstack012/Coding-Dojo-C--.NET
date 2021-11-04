using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // THREE BASIC ARRAYS
            // Create an array to hold integer values 0 through 9
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
            }
            // or
            int[] array2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = { "Tim", "Martin", "Nikki", "Sara" };

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] valid = { true, false, true, false, true, false, true, false, true, false };

            // bool[] booleanArr = new bool[10];
            // for (int i = 0; i < booleanArr.Length; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         booleanArr[i] = true;
            //     }
            //     else
            //     {
            //         booleanArr[i] = false;
            //     }
            // }

            // LIST OF FLAVORS
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("ButterFingers");
            flavors.Add("Cookie Dough");
            flavors.Add("Chocolate");
            flavors.Add("Andies Mint");
            flavors.Add("qwerty");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove(flavors[2]);
            Console.WriteLine(flavors.Count);

            Random rand = new Random();

            //             User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            // Add key / value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            Dictionary<string, string> peoplesFavs = new Dictionary<string, string>();

            foreach (string name in names)
            {
                peoplesFavs.Add(name, flavors[rand.Next(0, 5)]);
            }

            foreach (KeyValuePair<string, string> entry in peoplesFavs)
            {
                Console.WriteLine($"{entry.Key} likes {entry.Value}");
            }
        }
    }
}