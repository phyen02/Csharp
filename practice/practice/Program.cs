/*
Write a function which calculates the average of the numbers in a given array.
Note: Empty arrays should return 0.
*/

namespace CodeWar
{
    public static class Kata
    {
        public static void Main(string[] args)
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            double[] array2 = new double[]{};
            double ave = FindAverage(array);
            double ave2 = FindAverage(array2);
            Console.WriteLine(ave);
            Console.WriteLine(ave2);
        }

        public static double FindAverage(double[] array)
        {
            double average;
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                count++;
            }
            average = sum / array.Length;
            
            if (count > 0)
            {
                return average;
            }
            return 0;
        }
    }
}