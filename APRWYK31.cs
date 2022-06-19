using System;

namespace nwd
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            string tekst = Console.ReadLine();
            string[] tablica = tekst.Split();

            int temporary = 0;
            int temporary_extra = 0;

            for (int x = 0; x != tablica.Length; x++)
            {
                if (int.Parse(tablica[x]) > temporary)
                {
                    temporary = int.Parse(tablica[x]);
                    temporary_extra = x +1;
                }
            }
            Console.WriteLine(temporary + " " + temporary_extra);
        }
    }
}