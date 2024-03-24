namespace Events
{
    public static class IntExtensions
    {
        public static bool IsFibonacci(this int number)
        {
            int val1 = 5 * number * number + 4;
            int val2 = 5 * number * number - 4;

            return IsPerfectSquare(val1) || IsPerfectSquare(val2);
        }

        private static bool IsPerfectSquare(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
    }

    public class Program
    {
        static void Main()
        {
            int[] testNumbers = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 }; 
            foreach (int num in testNumbers)
            {
                Console.WriteLine($"{num} is Fibonacci: {num.IsFibonacci()}");
            }

            Console.WriteLine();

            int[] nonFibonacciNumbers = { 4, 6, 7, 10, 15, 30, 100 }; 
            foreach (int num in nonFibonacciNumbers)
            {
                Console.WriteLine($"{num} is Fibonacci: {num.IsFibonacci()}");
            }
        }
    }
}
