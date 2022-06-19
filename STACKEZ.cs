using System;

class Stos
{
    int top=0;
    int[] S = new int[100];
    
    public void push(int x)
    {
        S[top] = x;
        top++;
    }
    
    public int pop()
    {
        if(top>0)
        {
            top--;
            return S[top];
        }
        else return -1;
    }
    
    public int top_1()
    {
        if(top>0)
        {
            return S[top-1];
        }
        else
        {
            return -1;
        }
    }
}


public class Test
{
    public static void Main()
    {
        Stos s = new Stos();
        
        int t = int.Parse(Console.ReadLine());
        
        while(t-->0)
        {
            string[] z = Console.ReadLine().Split(' ');
            
            if(z[0]=="1")
            {
                s.push(int.Parse(z[1]));
            }
            else if(z[0]=="2")
            {
                s.pop();
            }
            else if(z[0]=="3")
            {
                if(s.top_1()!=-1)
                {
                    Console.WriteLine(s.top_1());
                }
                else
                {
                    Console.WriteLine("Empty!");
                }
            }
        }
        
        
    }
}