using System;
class Kopiec
{
    int[] H = new int[10001];
    int heapsize = 0;
    public void heap_insert(int x)
    {
        heapsize++;
        H[heapsize] = x;
        int i = heapsize;
        while (i>1 && H[i/2]>H[i])
        {
            int temp = H[i];
            H[i] = H[i/2];
            H[i/2] = temp;
            i = i/2;
        }
    }
    public int heap_extract_min()
    {
        if (heapsize == 0) return -1;
        int min = H[1];
        H[1] = H[heapsize];
        heapsize--;
        min_heapify(1);
        return min;
    }
    private void min_heapify(int i)
    {
        int min;
        int left = 2*i;
        int right = 2*i+1;
        if (left <= heapsize && H[i] > H[left])
            min = left;
        else min = i;
        if (right <= heapsize && H[right] < H[min]) 
            min = right;
        if (min != i)
        {
            int temp = H[i];
            H[i] = H[min];
            H[min] = temp;
            min_heapify(min);
        }
    }
}
public class Test
{
    public static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        while (q-->0)
        {
            Kopiec kopiec = new Kopiec();
            int max_banknot = 0;
            int[] ilosc = new int[10010];
            string[] s = Console.ReadLine().Split(' ');
            foreach (string str in s)
            {
                if (str == "w")
                {
                    int x = kopiec.heap_extract_min();
                    if (x == -1) continue;
                    if (ilosc[x] > 1) 
                    {
                        int n = x * ilosc[x];
                        if (n>10000)
                        {
                            if (n>max_banknot) max_banknot = n;
                        }
                        else 
                        {
                            if (ilosc[n]>0) ilosc[n]++;
                            else
                            {
                                ilosc[n]=1;
                                kopiec.heap_insert(n);
                            }
                        }
                        ilosc[x] = 0;
                    }
                    else
                    {
                        int x2 = kopiec.heap_extract_min();
                        if (ilosc[x2] > 1)
                        {
                            ilosc[x2]--;
                            kopiec.heap_insert(x2);
                        } else
                        {
                            ilosc[x2] = 0;
                        }
                        int n = x+x2;
                        if (n>10000)
                        {
                            if (n>max_banknot) max_banknot = n;
                        }
                        else 
                        {
                            if (ilosc[n]>0) ilosc[n]++;
                            else
                            {
                                ilosc[n]=1;
                                kopiec.heap_insert(n);
                            }
                        }
                    }
                } else
                if (str == "k")
                {
                    if (max_banknot == 0) Console.Write("bb");
                    else Console.Write(max_banknot);
                } else
                if (str == "0")
                {
                    break;
                } else
                {
                    int x = int.Parse(str);
                    if (ilosc[x]>0) ilosc[x]++;
                    else
                    {
                        ilosc[x]=1;
                        kopiec.heap_insert(x);
                    }
                }
                Console.Write(" ");
            }
            Console.WriteLine();                
        }
    }
}