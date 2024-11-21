/*
Khởi tạo các đối tượng thuộc lớp Animal
lần lượt gọi phương thức in ra chiều cao và cân nặng của các loài động vật.
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.weight = 5;
            cat.height = 30;

            cat.Info();
        }
    }

    class Animal
    {
        public int height;
        public int weight;

        public void Info()
        {
            Console.WriteLine("Height: " + height + "cm\nWeight: " + weight + "kg");
        }
    }
}