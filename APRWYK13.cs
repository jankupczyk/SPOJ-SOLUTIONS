using System;

public class Test
{
    public static void Main()
    {
        int wynik = 0;
        int q = int.Parse(Console.ReadLine());
        while (q-- > 0)
        {

            int n = int.Parse(Console.ReadLine());
                                                   
            string[] s = Console.ReadLine().Split(' ');
            int[] t = new int[n + 1];
            for (int i = 0; i < n; i++) t[i] = int.Parse(s[i]);
            wynik = 0;
            
            for (int i = 0; i < n; i++)
            {
                wynik = wynik + t[i];
            }
            Console.WriteLine(wynik);
        }
    }
}