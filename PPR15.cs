using System;

public class Test
{
    public static void Main()
    {
        int[] A = new int[100+2];
        A[0] = 4;
        A[1] = 7;
        for(int i=2; i<=100;i++){
            A[i]=(2*A[i-1]+5*A[i-2])%2011;
        }
        
        int q = int.Parse(Console.ReadLine());
            while (q--> 0)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(A[a]);
            }
    }
}