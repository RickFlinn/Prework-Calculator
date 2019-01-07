using System;

namespace Calculator
{
    class Program
    {

        // This program performs most basic calculator functions. 
        static void Main(string[] args)
        {
            Console.WriteLine("Dis a Calculalator. Good fer all yer basic Calculalatin' needs!");
            Console.WriteLine($"4 + 3 = {Summify(4, 3)}");
            Console.WriteLine($"7 * 8 = {Multiplerate(7, 8)}");
            Console.WriteLine($"20 / 3 = {Dividerize(20, 3)}");
            Console.WriteLine($"87 - 27.5 = {Subtractidate(87, 27.5)}");
            Console.WriteLine($"8 squared is = {SquareButLikeNotTheDance(8)}");
        }

        // Adds two numbers and returns the sum.
        public static double Summify (double x, double y)
        {
            Console.WriteLine("" + (x + y));
            return x + y;
        }

        // Multiplies two numbers and returns the product.
        public static double Multiplerate (double x, double y)
        {
            Console.WriteLine("" + (x * y));
            return x * y;
        }

        // Divides two numbers and returns whatever you call something you just divided
        public static double Dividerize (double x, double y)
        {
            Console.WriteLine("" + (x / y));
            return x / y;
        }
        
        // Divides two numbers and yeah my math terminology is weak, where is Hannah when you need her
        public static double Subtractidate (double x, double y)
        {
            Console.WriteLine("" + (x - y));
            return x - y;
        }

        // Squares given number and returns the square. No dancing involved here, take your damned countryside barn revelry elsewhere
        public static double SquareButLikeNotTheDance(double x)
        {
            Console.WriteLine("" + (x * x));
            return x * x;
        }

        // Returns square root of given number.
        public static double TheRootOfTheSquare (double x)
        {
            double ans = Math.Sqrt(x);
            Console.WriteLine(ans);
            return ans;
        }

        // Factorializes a given integer. 
        public static int Factoryilize(int x)
        {
            int ans = 1;
            for (int i = x; i > 0; i--)
            {
                ans *= i;
            }
            Console.WriteLine("" + ans);
            return ans;
        }

        // Returns the cosine of given angle. 
        public static double CosignNotYourLease (double x)
        {
            double ans = Math.Cos(x);
            Console.WriteLine(ans);
            return ans;
        }
    }
}
