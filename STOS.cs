using System;
class Stos
{
    int[] S = new int[1000000];
    int top = 0;
    public void push(int x)
    {
        S[top] = x;
        top++;
    }
    public int pop()
    {
        if (top != 0)
        {
            top--;
            return S[top];
        }
        return -1;
    }
};
public class Test
{
    public static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        while (q-->0)
        {
            string[] s = Console.ReadLine().Split(' ');
            if (s[0] == "PUSH")
            {
            }
            if (s[0] == "POP")
            {
            }
            if (s[0] == "MIN")
            {
            }
        }
    }
}