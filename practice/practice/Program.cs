/*
Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010)
and After Earth (2013). Jaden is also known for some of his philosophy that he delivers via Twitter.
When writing on Twitter, he is known for almost always capitalizing every word.
For simplicity, you'll have to capitalize each word, check out how contractions are expected
to be in the example below.

Your task is to convert strings to how they would be written by Jaden Smith.
The strings are actual quotes from Jaden Smith, but they are not capitalized in
the same way he originally typed them.

Example:
Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
*/

namespace CodeWar
{
    public static class Kata
    {
        public static void Main(string[] args)
        {
            string phrase = "How can mirrors be real if our eyes aren't real";
            Console.WriteLine(phrase.ToJadenCase());
        }

        public static string ToJadenCase(this string phrase)
        {
            string[] sentences = phrase.Split(' ');

            if (phrase == null)
            {
                return string.Empty;
            }
            else
            {
                for (int i = 0; i < sentences.Length; i++)
                {
                    sentences[i] = sentences[i][0].ToString().ToUpper() + sentences[i].Substring(1).ToString().ToLower();
                }
            }

            return string.Join(" ", sentences);
        }
    }
}