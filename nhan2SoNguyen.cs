using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger num1 = BigInteger.Parse("123456789123456789123456789");
        BigInteger num2 = BigInteger.Parse("987654321987654321987654321");
        BigInteger result = num1 * num2;
        Console.WriteLine("Kết quả nhân 2 số nguyên lớn: " + result);
    }
}
