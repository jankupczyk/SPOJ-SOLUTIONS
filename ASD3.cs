using System;

public class Test
{
    public static void Main()
    {
        int inptM = int.Parse(Console.ReadLine());
        while(inptM-- > 0)
        {
            int a = int.Parse(Console.ReadLine());
            string[] b = Console.ReadLine().Split(' ');
            int[] p_I = new int[a+1];
            
            for (int i = 0; i < a; i++) p_I[i] = int.Parse(b[i]);
            
            int opp = 0;
            
            for (int j =0; j < a; j++)
            {
                for (int k = j + 1; k < a; k++)
                {
                    if (p_I[j] > p_I[k])
                    {
                        opp++;
                    }
                }
            }
            Console.WriteLine(opp);
        }
    }
}
