
namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                int tempI = i;
                Thread t = new Thread(() => {
                    DemoThread("Thread " +  tempI);
                });
                t.Start();
            }
        }

        public static void DemoThread(string threadNoti)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(threadNoti + " - " + i);
            }
        }
    }
}