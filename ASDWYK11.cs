using System;

namespace wyszukiwanie
{
    class Program
    {
    public
        static void Main()
        {
            int q = int.Parse(Console.ReadLine());
            while (q-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                int[] T = new int[n + 1];
                for (int i = 0; i < n; i++)
                    T[i] = int.Parse(s[i]);
                int k = int.Parse(Console.ReadLine());

                bool x = true;
                for (int i = 0; i < n; i++)
                {
                    if (T[i] == k)
                    {
                        Console.WriteLine(i + 1);
                        x = false;
                        break;
                    }
                }
                if (x == true)
                {
                    Console.WriteLine("BRAK");
                }
            }
        }
    }
}