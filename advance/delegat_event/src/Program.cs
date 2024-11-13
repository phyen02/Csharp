using System.Reflection;

/*namespace delegate_usage
{
    public delegate void deInput(int x);
    // publisher -> class - phat event
    // subscriber -> class - nhan event
    class UserInput
    {
        public deInput deinput { get; set; }
        public void Input()
        {
            Console.Write("Nhap vao so nguyen: ");
            string s = Console.ReadLine();
            int i = Int32.Parse(s);
            deinput?.Invoke(i);
        }
    }

    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.deinput = Square;
        }
        public void Square(int i)
        {
            Console.WriteLine($"Can bac hai cua so {i} la: {Math.Sqrt(i)}");
        }

        public void PowNum(int i)
        {
            Console.WriteLine($"Binh phuong cua {i} la {i*i}");
        }
    }

    class TinhBinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.deinput = PowNum;
        }
        public void PowNum(int i)
        {
            Console.WriteLine($"Binh phuong cua {i} la {i*i}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                // publisher
                UserInput userInput = new UserInput();

                // subscriber
                TinhCan tinhCan = new TinhCan();
                tinhCan.Sub(userInput);

                // subscriber
                TinhCan tinhBP = new TinhCan();
                tinhBP.Sub(userInput);
                
                // Vấn đề của delegate: lúc này userInput chỉ in ra tinhBP
                // không in ra tinhCan mặc dù đã đăng ký sự kiện
                userInput.Input();
            } while (true);
        }
    }
}*/

namespace event_usage
{
    public delegate void deInput(int x);
    // publisher -> class - phat event
    // subscriber -> class - nhan event
    class DataInput : EventArgs 
    {
        public int data { set; get; }
        public DataInput(int x) => data = x;
    }
    
    class UserInput
    {
        public event EventHandler deInput; // ~ delegate void KIEU(object? Sender, EventArgs args)
        public void Input()
        {
            Console.Write("Nhap vao so nguyen: ");
            string s = Console.ReadLine();
            int i = Int32.Parse(s);
            deInput?.Invoke(this, new DataInput(i));
        }
    }

    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.deInput += Square;
        }
        public void Square(object obj, EventArgs e)
        {
            DataInput dataInput = (DataInput)e;
            int i = dataInput.data;
            Console.WriteLine($"Can bac hai cua so {i} la: {Math.Sqrt(i)}");
        }
    }

    class TinhBinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.deInput += PowNum;
        }
        public void PowNum(Object obj, EventArgs e)
        {
            DataInput dataInput = (DataInput)e;
            int i = dataInput.data;
            Console.WriteLine($"Binh phuong cua {i} la: {i*i}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine("\nThoat ung dung");
            };
            do
            {
                // publisher
                UserInput userInput = new UserInput();

                userInput.deInput += (sender, e) => {
                    DataInput dataInput = (DataInput)e;
                    Console.WriteLine("Ban vua nhap so " + dataInput.data);
                };

                // subscriber
                TinhCan tinhCan = new TinhCan();
                tinhCan.Sub(userInput);

                // subscriber
                TinhBinhPhuong tinhBP = new TinhBinhPhuong();
                tinhBP.Sub(userInput);
                userInput.Input();
            } while (true);
        }
    }
}
