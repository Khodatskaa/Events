namespace Events
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return !number.IsEven();
        }
    }

    public class Program
    {
        static void Main()
        {
            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"{num1} is even? {num1.IsEven()}"); 
            Console.WriteLine($"{num1} is odd? {num1.IsOdd()}");   

            Console.WriteLine($"{num2} is even? {num2.IsEven()}"); 
            Console.WriteLine($"{num2} is odd? {num2.IsOdd()}");
        }
    }
}
