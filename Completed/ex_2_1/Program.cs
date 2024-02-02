/* Viết trò chơi Kéo Búa Bao với cách chơi:
    - Người dùng sẽ nhập vào các số 1 hoặc 2 hoặc 3 tương ứng với kéo hoặc búa hoặc bao.
    - Máy sẽ ngẫu nhiên sinh ra một số trong 3 số và tính toán máy hoặc người chiến thắng.
    - Nhớ phải in kết quả ra màn hình.
**Yêu cầu: Dùng if-else và switch-case
*/

using System;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            int playerChoose = -1;
            int botChoose = 0;
            Random botRd = new Random();

            // MENU GAME
            Console.WriteLine("************************************");
            Console.WriteLine("**  SCISSORS, HAMMER, PAPER GAME  **");
            Console.WriteLine("************************************");
            Console.WriteLine("*    0 - Exit                      *");
            Console.WriteLine("*    1 - Scissor                   *");
            Console.WriteLine("*    2 - Hammer                    *");
            Console.WriteLine("*    3 - Paper                     *");
            Console.WriteLine("************************************");
            Console.Write("Your option: ");
            playerChoose = Convert.ToInt32(Console.ReadLine());

            // Function: for bot to random from 1 to 3 (>= 1 && < 4)
            botChoose = botRd.Next(1, 4);

            /* Function:
                - for player to choose option
                - output result (win or lose && player and bot option)
            */
            switch (playerChoose){
                case 0:
                    break;
                case 1:
                    Console.WriteLine("You: Scissor");
                    if (botChoose == 1){
                        Console.WriteLine("Bot: Scissor");
                        Console.Write("   Draw");
                    }
                    else if (botChoose == 2){
                        Console.WriteLine("Bot: Hammer");
                        Console.Write("   Lose");
                    }
                    else if (botChoose == 3){
                        Console.WriteLine("Bot: Paper");
                        Console.Write("   Win");
                    }
                    break;
                case 2:
                    Console.WriteLine("You: Hammer");
                    if (botChoose == 1){
                        Console.WriteLine("Bot: Scissor");
                        Console.Write("   Win");
                    }
                    else if (botChoose == 2){
                        Console.WriteLine("Bot: Hammer");
                        Console.Write("   Draw");
                    }
                    else if (botChoose == 3){
                        Console.WriteLine("Bot: Paper");
                        Console.Write("   Lose");
                    }
                    break;
                case 3:
                    Console.WriteLine("You: Paper");
                    if (botChoose == 1){
                        Console.WriteLine("Bot: Scissor");
                        Console.Write("   Lose");
                    }
                    else if (botChoose == 2){
                        Console.WriteLine("Bot: Hammer");
                        Console.Write("   Win");
                    }
                    else if (botChoose == 3){
                        Console.WriteLine("Bot: Paper");
                        Console.Write("   Draw");
                    }
                    break;
                default:
                    Console.WriteLine("***********************");
                    Console.WriteLine("* Please input number * ");
                    Console.WriteLine("***********************");
                    break;
            }
        }
    }
}