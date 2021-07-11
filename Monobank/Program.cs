using System;

namespace Monobank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("For how many months?");
            int month = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= month; i++)
            {
                amount += amount / 100 * 14;                
            }
            Console.WriteLine($"After {month} months your amount will be {amount}.");
        }
    }
}
