namespace Events
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 11;

            Console.WriteLine($"{num1} is prime? {num1.IsPrime()}"); 
            Console.WriteLine($"{num2} is prime? {num2.IsPrime()}"); 
            Console.WriteLine($"{num3} is prime? {num3.IsPrime()}"); 
        }
    }
}
