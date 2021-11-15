using System;
using System.Collections.Generic;

namespace puzzles
{
    public class Program
    {


        public static int[] RandArray()
        {
            Random rand = new Random();
            int[] array = new int[10];
            int min = 25;
            int max = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(5, 26);
                Console.WriteLine(array[i]);
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine($"Min is {min}");
            Console.WriteLine($"Max is {max}");
            Console.WriteLine($"Sum is {sum}");
            return array;
        }


        public static string CoinToss()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing the coin!");
            string result = "";
            int flip = rand.Next(1, 3);
            if (flip == 1)
            {
                result = "Heads!";
            }
            if (flip == 2)
            {
                result = "Tails!";
            }
            Console.WriteLine(result);
            return result;
        }

        public static double TossMultipleCoins(int num)
        {
            int i = 0;
            string[] tosses = new string[num];
            int sumMulti = 0;
            while (i < num)
            {
                tosses[i] = CoinToss();
                if (tosses[i] == "Heads!")
                {
                    // finding the total of heads to find the ratio
                    sumMulti += 1;
                }
                i++;
            }
            double ratio = (double)sumMulti / (double)num; // this takes the num of heads divided by total number of tosses
            Console.WriteLine($"Heads was tossed at a rate of {ratio}");
            return ratio;
        }

        public static List<string> Names()
        {
            // Create an list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            Random rand = new Random();
            // shuffle names
            for (var i = 0; i < names.Count / 2; i++)
            {
                // swap names[i] with names[randomIndex]
                int randomIndex = rand.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }
            // print new order of names
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            // remove names not larger than 5 characters
            for (var i = 0; i < names.Count; i++)
            {
                if (names[i].Length <= 5)
                    names.RemoveAt(i);
            }
            return names;
        }

        // public static List<string> Names()
        // {
        //     Random rand = new Random();
        //     List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
        //     for (int i = 0; i < names.Count; i++)
        //     {
        //         int asdf = rand.Next(5);
        //         string temp = names[i];
        //         names[i] = names[asdf];
        //         names[asdf] = temp;
        //     }
        //     for (int i = 0; i < names.Count; i++)
        //     {
        //         Console.WriteLine(names[i]);
        //         if (names[i].Length < 5)
        //         {
        //             names.Remove(names[i]);
        //         }
        //     }
        //     return names;
        // }

        static void Main(string[] args)
        {
            // RandArray();
            // CoinToss();
            // TossMultipleCoins(10);
            // Names();
        }
    }
}
