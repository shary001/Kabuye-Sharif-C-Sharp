using System;
namespace savingCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            // switch and while loop

            Console.WriteLine("Part 3, compound interest");

            Console.Write("Enter principal: ");
            decimal principal = decimal.Parse(Console.ReadLine());


            Console.Write("Enter duration in years: ");
            int duration = int.Parse(Console.ReadLine());

            decimal interestRate = 0m;

            // I = P x R x T
            interestRate = principal switch
            {
                >= 5000000m => 8m / 100,
                >= 2000000m => 6m / 100,
                >= 1000000m => 4m / 100,
                >= 500000m => 2m / 100,
                _ => 1m / 100
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

        }
    }
}

