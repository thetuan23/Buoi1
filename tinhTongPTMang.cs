using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        int sum = 0;
        foreach (int num in a)
        {
            sum += num;
        }
        Console.WriteLine("Tổng các phần tử trong mảng: " + sum);
    }
}
