namespace Events
{
    public static class StringExtensions
    {
        public static bool AreParenthesesValid(this string str)
        {
            Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (parenthesesMap.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (parenthesesMap.ContainsValue(c))
                {
                    if (stack.Count == 0 || parenthesesMap[stack.Peek()] != c)
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            return stack.Count == 0;
        }
    }

    public class Program
    {
        static void Main()
        {
            string str = "({[]})";
            Console.WriteLine(str.AreParenthesesValid());
        }
    }
}
