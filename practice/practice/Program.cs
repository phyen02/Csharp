/*
Complete the solution so that it reverses the string passed into it.
'world'  =>  'dlrow'
'word'   =>  'drow'
*/

public static class Kata
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        for (int i = str.Length+1; i < str.Length; i--)
        {
            Console.Write(str);
        }
    }
}