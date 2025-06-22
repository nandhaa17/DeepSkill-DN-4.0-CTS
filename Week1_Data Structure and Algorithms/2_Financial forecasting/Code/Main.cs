using System;

class Program
{
    
    public static double Compound(double principal, double roi, int years)
    {
        if (years == 0)
            return principal;
        return (1 + roi) * Compound(principal, roi, years - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual rate of interest(in %): ");
        double roi = Convert.ToDouble(Console.ReadLine())/100;

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double value = Compound(principal, roi, years);
        Console.WriteLine($"Future Value after {years} years: {value:F2}");
    }
}
