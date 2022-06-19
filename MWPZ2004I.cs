using System;

namespace Czekolada
{
    class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            while (count-- >0)
            {
                int tableArray = int.Parse(Console.ReadLine());
                int arrayCopy = tableArray;
                int[] intTable = new int[tableArray];
                string[] stringTable = Console.ReadLine().Split(' ');

                for(int x = arrayCopy; x != 0; x--)
                {
                    intTable[x - 1] = int.Parse(stringTable[x - 1]);

                }
                Array.Sort(intTable);

                for (int x = arrayCopy; x > 0; x--)
                {
                    Console.Write(intTable[x-1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}