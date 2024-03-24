namespace Events
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

    public class Program
    {
        static void Main()
        {
            string text = "This is a sample sentence with several words.";
            int wordCount = text.WordCount();
            Console.WriteLine($"Number of words in the text: {wordCount}");

            string emptyText = "";
            int emptyWordCount = emptyText.WordCount();
            Console.WriteLine($"Number of words in the empty text: {emptyWordCount}");

            string whitespaceText = "    \t \n \r ";
            int whitespaceWordCount = whitespaceText.WordCount();
            Console.WriteLine($"Number of words in the whitespace text: {whitespaceWordCount}");

            string singleWordText = "Hello";
            int singleWordCount = singleWordText.WordCount();
            Console.WriteLine($"Number of words in the single word text: {singleWordCount}");
        }
    }
}
