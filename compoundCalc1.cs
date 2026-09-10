using System;
namespace savingCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            //If and for loop

            Console.WriteLine("Part 2, compound interest");

            Console.Write("Enter principal: ");
            decimal principal = decimal.Parse(Console.ReadLine());


            Console.Write("Enter duration in years: ");
            int duration = int.Parse(Console.ReadLine());

            decimal interestRate = 0m;

            // I = P x R x T

            if (principal >= 500000)
            {
                interestRate = 8m / 100;

            }
            else
            {
                interestRate = 4m / 100;
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
        }
    }
}

