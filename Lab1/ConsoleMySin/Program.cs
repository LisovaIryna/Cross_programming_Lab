using System;

namespace ConsoleMySin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("────────────────────────────────────────────────────────────");
            Console.WriteLine("Task 1:");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Enter the number: ");

            int number;
            if (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();
                Console.WriteLine(" Incorrect input. An integer must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            double hundred_count = MyLib.MySin.Hundred_count(number);
            Console.WriteLine(" Number of hundreds: " + hundred_count);
            Console.WriteLine("────────────────────────────────────────────────────────────");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("────────────────────────────────────────────────────────────");
            Console.WriteLine("Task 2:");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Enter the n: ");

            int n;
            if (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine();
                Console.WriteLine(" Incorrect input. An integer must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (n <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(" A number greater than zero must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine();
            Console.Write(" Enter the a: ");

            double a;
            if (!Double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine();
                Console.WriteLine(" Incorrect input. An double must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            double multiplication_P = MyLib.MySin.Multiplication_P(n, a);
            Console.WriteLine(" P: " + multiplication_P);
            Console.WriteLine("────────────────────────────────────────────────────────────");


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("────────────────────────────────────────────────────────────");
            Console.WriteLine("Task 3:");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Enter the eps: ");

            double eps;
            if (!Double.TryParse(Console.ReadLine(), out eps))
            {
                Console.WriteLine();
                Console.WriteLine(" Incorrect input. An integer must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (eps <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(" A number greater than zero must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write(" Enter the n: ");

            int n_;
            if (!Int32.TryParse(Console.ReadLine(), out n_))
            {
                Console.WriteLine();
                Console.WriteLine(" Incorrect input. An integer must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (n_ <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(" A number greater than zero must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write(" Enter the x: ");

            double x;
            if (!Double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine();
                Console.WriteLine(" Incorrect input. An double must be entered.");
                Console.WriteLine(" Press \"Enter\" and the program will shut down.");
                Console.WriteLine("────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }

            double sum_row = MyLib.MySin.Sum_row(eps, n_, x);
            double function_x = MyLib.MySin.Function_x(eps, n_, x);
            double сalculation_error = MyLib.MySin.Calculation_error(sum_row,function_x);
            Console.WriteLine();
            Console.WriteLine(" Amount: " + sum_row);
            Console.WriteLine(" Function x: " + function_x);
            Console.WriteLine(" Calculation error: " + сalculation_error);
            Console.WriteLine("────────────────────────────────────────────────────────────");
        }
    }
}
