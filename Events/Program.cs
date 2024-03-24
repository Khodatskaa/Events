namespace Events
{
    public static class StringExtensions
    {
        public static int CountSentences(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int count = 0;
            foreach (char c in input)
            {
                if (c == '.' || c == '!' || c == '?')
                    count++;
            }
            return count;
        }
    }
    public class Program
    {
        static void Main()
        {
            string text1 = "The car is driving.";
            string text2 = "The car is blue. The blue car is driving down the street.";

            Console.WriteLine($"Number of sentences in text 1: {text1.CountSentences()}"); 
            Console.WriteLine($"Number of sentences in text 2: {text2.CountSentences()}");
        }
    }
}
