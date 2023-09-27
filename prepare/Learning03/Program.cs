using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 =new Fraction();
        Console.WriteLine(f1.GetFratctionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 =new Fraction();
        Console.WriteLine(f2.GetFratctionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 =new Fraction();
        Console.WriteLine(f3.GetFratctionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 =new Fraction();
        Console.WriteLine(f4.GetFratctionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}