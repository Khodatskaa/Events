namespace Events
{
    public static class StringExtensions
    {
        public static int LengthOfLastWord(this string str)
        {
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                return words[words.Length - 1].Length;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            string str = "Hello World";
            Console.WriteLine(str.LengthOfLastWord());
        }
    }
}
