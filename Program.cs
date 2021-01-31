using System;

namespace PellSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string line;
            Console.WriteLine("Enter number: ");
            while ((line = System.Console.ReadLine()) != null)
            {
                int.TryParse(line, out n);

                if (n < 0)
                {
                    System.Console.WriteLine("Only numbers greater than zero is allowed");
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(PellSeries(i) + " ");
                    }
                }
                
                Console.WriteLine("\nEnter number: ");
            }
            
            
        }

        private static int PellSeries(int n)
        {
            
                if (n <= 2)
                    return n;
                int a = 1;
                int b = 2;
                int c;
                for (int i = 3; i <= n; i++)
                {
                    c = 2 * b + a;
                    a = b;
                    b = c;
                }
            return b; ;
            
            
        }
    }

    
}
