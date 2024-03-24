namespace Events
{
    public static class IntExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int number = 5;
            if (number.IsOdd())
            {
                Console.WriteLine("The number is odd.");
            }
            else
            {
                Console.WriteLine("The number is even.");
            }
        }
    }
}
