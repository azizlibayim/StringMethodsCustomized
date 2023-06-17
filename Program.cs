namespace StringMethodsCostumized
{
    using System;
    using System.Diagnostics.Tracing;

    public class Program
    {
        public static void Main(string[] args)
        {
            string word = "   Word   ";
            char[] charsToTrim = { ' ' };

            string trimmedString = Trim(word, charsToTrim);
            Console.WriteLine(trimmedString);
            string Trimmedstring = Program.TrimStart(word, charsToTrim);
            Console.WriteLine(trimmedString);
            string trimmedstring = TrimEnd(word, charsToTrim);
            Console.WriteLine(trimmedString);
        }

        public static string Trim(string word, char[] charsToTrim)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;

            int startIndex = 0;
            int endIndex = word.Length - 1;

            while (startIndex <= endIndex && charsToTrim.Contains(word[startIndex]))
            {
                startIndex++;
            }

            while (endIndex >= startIndex && charsToTrim.Contains(word[endIndex]))
            {
                endIndex--;
            }

            return word.Substring(startIndex, endIndex - startIndex + 1);
        }
        public static string TrimStart(string word, char[] charsToTrim)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;

            int startIndex = 0;

            while (startIndex < word.Length && charsToTrim.Contains(word[startIndex]))
            {
                startIndex++;
            }
            return word.Substring(startIndex);

        }
        public static string TrimEnd(string word, char[] charsToTrim)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;

            int endIndex = word.Length - 1;

            while (endIndex >= 0 && charsToTrim.Contains(word[endIndex]))
            {
                endIndex--;
            }

            return  word.Substring(0, endIndex + 1);
        }
    }

}
