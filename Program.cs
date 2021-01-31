using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int number;
            System.Console.WriteLine("Enter number: ");
            while ((line = System.Console.ReadLine()) != null)
            {
                int.TryParse(line, out number);
                if (number < 0)
                {
                    System.Console.WriteLine("Only numbers greater than zero is allowed");
                }
                else
                {
                    PrintTriangle(number);
                }
                
                System.Console.WriteLine("Enter number: ");
            }
        }

        private static void PrintTriangle(int n)
        {
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
