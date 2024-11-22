namespace System
{
    public class Kata
    {
        public static int FindSmallestInt(int[] args)
        {
            int min = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if(args[i] < min)
                    min = args[i];
            }
            return min;
        }

        public static void Main(string[] args)
        {
            //int[] arr1 = new int[4] {34, 15, 88, 2};
            int[] arr2 = new int[4] {34, -345, -1, 100};
            //Console.WriteLine(FindSmallestInt(arr1));
            Console.WriteLine(FindSmallestInt(arr2));
        }
    }
}