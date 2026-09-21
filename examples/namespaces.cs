using System;
using AA = A.A;
using AB = A.B;

public class namespaces
{
public static void Main()
	{
        A.A.PrintSum(7,11);
        A.B.PrintDiff(7, 11);
        AA.PrintMultiply(7,11);
        AB.PrintDivide(7,11);
    }
}

namespace A
{
    public class A
    {
        public static void PrintSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void PrintMultiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}

namespace A
{
    public class B
    {
        public static void PrintDiff(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void PrintDivide(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}