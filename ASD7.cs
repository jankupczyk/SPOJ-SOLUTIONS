using System;

namespace Wstawmalejaco
{
    class Program
    {
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = x;

            string[] a = Console.ReadLine().Split(' ');
            int[] intTable = new int[x];
            int licznik = 0;
            while (x-- > 0)
            {
                intTable[licznik] = int.Parse(a[licznik]);
                licznik++;
            }
            Array.Sort(intTable);

            licznik = y;
            while (y-- > 0)
            {
                Console.WriteLine(intTable[licznik-1]);
                licznik--;
            }

        }
    }
}

