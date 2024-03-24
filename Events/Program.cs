namespace Events
{
    public static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            return array.Where(predicate).ToArray();
        }
    }

    public class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            int[] oddNumbers = numbers.Filter(x => x % 2 != 0);
            Console.WriteLine("Odd numbers:");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            int[] greaterThanFive = numbers.Filter(x => x > 5);
            Console.WriteLine("Numbers greater than 5:");
            foreach (var num in greaterThanFive)
            {
                Console.WriteLine(num);
            }
        }
    }
}
