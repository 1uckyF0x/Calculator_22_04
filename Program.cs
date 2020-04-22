using System;

namespace Calculator
{
    class Program
    {        
        public delegate double Calculation(double x, double y);
        public delegate void Output(string message);
        public static event Output Out;
        
        static void Main(string[] args)
        {
            double x = Convert.ToInt32(Console.ReadLine());
            char p = Convert.ToChar(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            Out += Message;

            Calculation calc;

            if (p == '+')
            {
                calc = Sum;
                double result = calc(x, y);
                Out?.Invoke($"The sum is {result}");
            }

            else if (p == '-')
            {
                calc = Subtract;
                double result = calc(x, y);
                Out?.Invoke($"subtraction is {result}");
            }

            else if (p == '*')
            {
                calc = Multiplication;
                double result = calc(x, y);
                Out?.Invoke($"multiplication is {result}");
            }

            else if (p == '/')

                if (y == 0)
                {
                    Console.WriteLine("You cannot divide by 0!");
                }

                else
                {
                    calc = Division;
                    double result = calc(x, y);
                    Out?.Invoke($"division is {result}");
                }

            else
            {
                Console.WriteLine("error");
            }      

        }

        private static double Sum (double x, double y)
        {
            return x + y;
        }

        private static double Subtract (double x, double y)
        {
            return x - y;
        }

        private static double Multiplication (double x, double y)
        {
            return x * y;
        }

        private static double Division (double  x, double y)
        {
            return x / y;
        }

        private static void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
