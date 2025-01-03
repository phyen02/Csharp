namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.Write(Tribonacci([1, 1, 1], 10)[i] + " ");
                // Console.Write(Tribonacci([0, 0, 1], 10)[i] + " ");
                Console.Write(Tribonacci([0, 1, 1], 10)[i] + " ");
            }
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] tribonacci = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (i < 3)
                {
                    tribonacci[i] = signature[i];
                }
                else
                {
                    tribonacci[i] = tribonacci[i-1] + tribonacci[i-2] + tribonacci[i-3];
                }
            }
            return tribonacci;
        }
    }
}