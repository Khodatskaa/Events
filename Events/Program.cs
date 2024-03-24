namespace Events
{
    public static class StringExtensions
    {
        public static int CountVowels(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int count = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                    count++;
            }
            return count;
        }
    }

    public class Program
    {
        static void Main()
        {
            string str1 = "Hello World";
            string str2 = "This is a test string";
            string str3 = "";

            Console.WriteLine($"Number of vowels in \"{str1}\": {str1.CountVowels()}"); 
            Console.WriteLine($"Number of vowels in \"{str2}\": {str2.CountVowels()}"); 
            Console.WriteLine($"Number of vowels in empty string: {str3.CountVowels()}"); 
        }
    }
}
