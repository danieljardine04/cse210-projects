using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction();
        Fraction frac1 = new Fraction(5);
        Fraction frac2 = new Fraction(6, 7);


        Console.WriteLine(frac.getTop());
        Console.WriteLine(frac1.getTop());
        Console.WriteLine(frac2.getTop());
        Console.WriteLine(frac2.getBottom());

        frac.setBottom(2);
        frac1.setBottom(6);

        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());
        
    }
}