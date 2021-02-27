using System;

namespace MyLib
{
    /// Сalculation of mathematical functions

    public class MySin
    {
        /// <summary>
        /// Hundred_count(number)
        /// </summary>
        /// <param name="number">an integer entered from the keyboard by the user — argument of the Hundred_count function</param>
        /// <returns>Returns the value of the Hundred_count function (number of hundreds) for a given integer.</returns>
        
        public static int Hundred_count(int number)
        {
            if (number < 0)
            {
                number = number * -1;
            }

            Console.WriteLine();

            int hundred_count;
            hundred_count = number / 100;
                        
            return hundred_count;
        }

        /// <summary>
        /// Multipliation_P(n,a)
        /// </summary>
        /// <param name="n">an integer entered from the keyboard by the user — first argument of the Multiplication_P function</param>
        /// <param name="a">an double entered from the keyboard by the user — second argument of the Multiplication_P function</param>
        /// <returns>Returns the value of the Multiplication_P  for a given integer and double.</returns>

        public static double Multiplication_P(int n, double a)
        {
            double P = 1;
            if (n == 1)
            {
                P = a;
            }

            else
            {
                for (int i = 1; i <= n; i++)
                {
                    P = P * (a + i - 1);
                }
            }

            Console.WriteLine();

            return P;
        }

        /// <summary>
        /// Sum_row(eps,n_,x)
        /// </summary>
        /// <param name="eps">an double entered from the keyboard by the user — first argument of the Sum_row function</param>
        /// <param name="n_">an int entered from the keyboard by the user — second argument of the Sum_row function</param>
        /// <param name="x">an double entered from the keyboard by the user — third argument of the Sum_row function</param>
        /// <returns>Returns the value of the Sum_row  for a given integer and double.</returns>

        public static double Sum_row(double eps, int n_, double x)
        {
            double sum = 0;
            for (int i = 1; i <= n_; i++)
            {
                sum += Math.Pow(-1, 3 * i + 1) * (Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1));
                if (Math.Abs(sum) < eps)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>
        /// Function_x(eps,n_,x)
        /// </summary>
        /// <param name="eps">an double entered from the keyboard by the user — first argument of the Function_x function</param>
        /// <param name="n_">an int entered from the keyboard by the user — second argument of the Function_x function</param>
        /// <param name="x">an double entered from the keyboard by the user — third argument of the Function_x function</param>
        /// <returns>Returns the value of the Function_x  for a given integer and double.</returns>

        public static double Function_x(double eps, int n_, double x)
        {
            double function_x = (1 + Math.Pow(x, 2)) / 2 * Math.Atan(x) - x / 2;

            return function_x;
        }

        /// <summary>
        /// Calculation_error(sum,function_x)
        /// </summary>
        /// <param name="sum">an double from the Sum_row function — first argument of the Calculation_error function</param>
        /// <param name="function_x">an double from the Sum_row function — second argument of the Calculation_error function</param>
        /// <returns>Returns the value of the Calculation_error  for a given double and double.</returns>

        public static double Calculation_error(double sum, double function_x)
        {
            double сalculation_error = Math.Abs(sum - function_x) / function_x * 1;

            return сalculation_error;
        }
    }
}