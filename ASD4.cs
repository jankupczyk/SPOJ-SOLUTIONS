using System;

public class najwiekszeliczby
{
    public static void Main()
    {
        int X_Y = int.Parse(Console.ReadLine());
        int[] epty = new int[X_Y+1];
        string[] volot = new string[X_Y+1];
        

        for(int i_I = 0; i_I < X_Y; i_I++)
        {
            string[] s = Console.ReadLine().Split(' ');
            epty[i_I] = int.Parse(s[0]);
            volot[i_I] = s[1];
        }
        Array.Sort(epty, volot);
        

        int Y_X = int.Parse(Console.ReadLine());
        for(int i_II = 0; i_II < Y_X; i_II++)
        {
            Console.WriteLine(volot[X_Y-i_II]);
        }
    }
}