using System;
public class Test
{
    static void Breaking(int n, int licznik)
    {
        int i = 2;
        Console.Write("Case " + licznik + ": ");
        while (n > 1)
        {

            if (n % i == 0)
            {
                Console.Write(i); Console.Write(" ");
                while (n % i == 0) n = n / i;
            }
            i++;
        }
    }
    public static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        int licznik = 1;
        while (q-- > 0)
        {
            int input = int.Parse(Console.ReadLine());
            Breaking(input, licznik);
            licznik++;
            Console.WriteLine();
        }
    }
}