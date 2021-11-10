using System;

namespace multTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multTable = new int[10, 10];
            int row = 1;
            for (int i = 0; i < multTable.GetLength(0); i++)
            {
                string display = "[";
                int asdf = row;
                for (int z = 0; z < multTable.GetLength(0); z++)
                {
                    multTable[i, z] = asdf;
                    if (z == multTable.GetLength(0) - 1)
                    {
                        display += $"{asdf}";
                    }
                    else
                    {
                        display += $"{asdf}, ";
                    }
                    asdf += row;
                }
                display += "]";
                Console.WriteLine(display);
                row += 1;
            }
        }
    }
}