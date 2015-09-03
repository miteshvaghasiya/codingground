using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        List<int> a = {2,4,-8,3,-3,5};
        Console.WriteLine("Hello, World!" + Segsum(a, a.Length, 0, a.Length));
    }
    static int Segsum(List<int> a, int l, int i, int j)
    {
        int sum = 0;
        for(int c = 0; i < l && c < j; i++, c++)
        {
            sum += a[i];
        }
        return sum;
    }
}
