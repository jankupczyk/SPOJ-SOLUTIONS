using System;
public class kroliki

    {
        static int makekroliki(int i)
        {
            if (i==0|i==1|i==2) return 1;
            return makekroliki(i-1)+2*makekroliki(i-3);
        }


        static void Main()
        {
            int q = int.Parse(Console.ReadLine());
            while (q-- > 0)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(makekroliki(a));
            }
        }
    }