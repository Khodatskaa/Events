namespace Events
{
    public static class StringExtensions
    {
        public static int CountConsonants(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int count = 0;
            foreach (char c in input.ToLower())
            {
                if (char.IsLetter(c) && !"aeiou".Contains(c))
                    count++;
            }
            return count;
        }
    }

    public class Program
    {
        static void Main()
        {
            string str1 = "Hello world";
            string str2 = "This is a test string";

            Console.WriteLine($"Number of consonants in \"{str1}\": {str1.CountConsonants()}");
            Console.WriteLine($"Number of consonants in \"{str2}\": {str2.CountConsonants()}");
        }
    }
}
