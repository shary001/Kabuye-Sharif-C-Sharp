 using System;
 class Program
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

/*
 //If and for loop

Console.WriteLine("Part 2, compound interest");

Console.Write("Enter principal: ");
decimal principal = decimal.Parse(Console.ReadLine());


Console.Write("Enter duration in years: ");
int duration = int.Parse(Console.ReadLine());

decimal interestRate = 0m;

// I = P x R x T

if(principal >= 500000)
{
    interestRate = 8m/100;

}
else
{
    interestRate = 4m/100;
}

decimal I = principal * interestRate * duration;

decimal currentBalance = principal;
Console.WriteLine($"Interest Rate: UGX | {interestRate,2}\n");

Console.WriteLine("************ Savings Summary ****************\n");

for (int year = 1; year <= duration; year++)
{
    currentBalance = currentBalance + (year * I);

    Console.WriteLine($"Year {year,-3} Current balance: UGX | {currentBalance,3:N2}");
}
 */

/*
 // switch and while loop
Console.WriteLine("Part 2, compound interest");

Console.Write("Enter principal: ");
decimal principal = decimal.Parse(Console.ReadLine());


Console.Write("Enter duration in years: ");
int duration = int.Parse(Console.ReadLine());

decimal interestRate = 0m;

// I = P x R x T
interestRate = principal switch 
{ 
    >= 5000000m => 8m/100,
    >= 2000000m => 6m/100,
    >= 1000000m => 4m/100,
    >= 500000m => 2m/100,
    _ => 1m/100
};

decimal I = principal * interestRate * duration;

decimal currentBalance = principal;
Console.WriteLine($"Interest Rate: UGX | {interestRate,2}\n");

Console.WriteLine("************ Savings Summary ****************\n");
int year = 1;

while (year <= duration)
{
    if (year > duration) break;
    currentBalance = currentBalance + (year * I);

    Console.WriteLine($"Year {year,-3} Current balance: UGX | {currentBalance,3:N2}");
    year++;
    
}
 */

/*
 //do while loop with if else if

Console.WriteLine("Part 2, compound interest");

Console.Write("Enter principal: ");
decimal principal = decimal.Parse(Console.ReadLine());


Console.Write("Enter duration in years: ");
int duration = int.Parse(Console.ReadLine());

decimal interestRate = 0m;

// I = P x R x T
if (principal >= 5000000m)
{
    interestRate = 8m / 100;
}
else if (principal >= 2000000m) 
{
    interestRate = 6m / 100;
} 
else if (principal >= 1000000)
{
    interestRate = 4m / 100;
}
else if (principal >= 500000)
{
    interestRate = 2m / 100;
}
else
{
    interestRate = 1m / 100;
}


decimal I = principal * interestRate * duration;

decimal currentBalance = principal;
Console.WriteLine($"Interest Rate: UGX | {interestRate,2}\n");

Console.WriteLine("************ Savings Summary ****************\n");
int year = 1;

do
{
    if (year > duration) break;
    currentBalance = currentBalance + (year * I);

    Console.WriteLine($"Year {year,-3} Current balance: UGX | {currentBalance,3:N2}");
    year++;

}
while (year <= duration);
 */



