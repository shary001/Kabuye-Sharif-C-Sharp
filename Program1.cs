 using System;
 class Program1
{
    static void Main(string[] args)
    {
        Part1_SimpleSavingsCalculator();

    }
    // ---------- Part 1: Simple Interest ---------
    static void
Part1_SimpleSavingsCalculator()
    {
        Console.WriteLine("=== Part 1: Savings Calculator(Simple Interest) === ");

        Console.Write("Enter principal amount: ");
        string principalInput = Console.ReadLine();
        decimal principal = Convert.ToDecimal(principalInput);

        Console.Write("Enter annual interest rate: ");
        string interestRateInput = Console.ReadLine();
        decimal interestRate = Convert.ToDecimal(interestRateInput);

        Console.Write("Enter duration in years: ");
        string durationInput = Console.ReadLine();
        int duration = Convert.ToInt32(durationInput);


        decimal finalBalance = principal + (principal * (interestRate / 100) * duration);
        decimal interest = finalBalance - principal;

        Console.WriteLine($"Interest: {interest}");
        Console.WriteLine("Final balance after " + duration + " years: " + finalBalance);

        //I = P x R x T
    }

}


