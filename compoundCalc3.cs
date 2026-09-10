using System;

namespace compoundCalc3
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
