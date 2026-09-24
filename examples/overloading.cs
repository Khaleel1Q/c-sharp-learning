using System;

public class Overloading
{
    public static void Main()
    {
        int sum;
        Console.WriteLine(Add(5, 10, out sum));
        Console.WriteLine(sum);
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }


    public static int Add(int a, int b, out int sum)
    {
        sum = a + b;
        return sum+sum;
    }
}