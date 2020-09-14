using System;

namespace Week3Percentages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Result;

            Console.WriteLine("What is the maximum score?");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your score?");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / Maximum;

            Console.WriteLine($"You scored {Result}%.");

            if (Result >= 90)
            {
                Console.WriteLine("5");
            }
            else if (Result >= 80)
            {
                Console.WriteLine("4");
            }
            else if (Result >= 61)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("2");
            }

        }
    }
}
