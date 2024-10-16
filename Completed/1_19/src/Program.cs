/*
    Lập trình game kéo – búa – bao
    **Yêu cầu:** Dùng if/else và switch/case
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int playerChoose = -1;
            Random random = new Random();
            int botChoose = random.Next(1, 3); // 1 = Rock, 2 = Paper, 3 = Scissors

            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("ROCK PAPER SCISSORS GAME");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("-----------------------------");
                Console.Write("You choose: ");
                playerChoose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------");

                //Switch case statement
                switch (playerChoose)
                {
                    case 0: break;
                    case 1:
                        switch (botChoose)
                        {
                            case 1:
                                Console.WriteLine("Bot: Rock");
                                Console.WriteLine("Draw");
                                break;
                            case 2:
                                Console.WriteLine("Bot: Paper");
                                Console.WriteLine("Bot win");
                                break;
                            case 3:
                                Console.WriteLine("Bot: Scissors");
                                Console.WriteLine("You win");
                                break;
                            default: break;
                        }
                        break;
                    case 2:
                        switch (botChoose)
                        {
                            case 1:
                                Console.WriteLine("Bot: Rock");
                                Console.WriteLine("You win");
                                break;
                            case 2:
                                Console.WriteLine("Bot: Paper");
                                Console.WriteLine("Draw");
                                break;
                            case 3:
                                Console.WriteLine("Bot: Scissors");
                                Console.WriteLine("Bot win");
                                break;
                            default: break;
                        }
                        break;
                    case 3:
                        switch (botChoose)
                        {
                            case 1:
                                Console.WriteLine("Bot: Rock");
                                Console.WriteLine("Bot win");
                                break;
                            case 2:
                                Console.WriteLine("Bot: Paper");
                                Console.WriteLine("You win");
                                break;
                            case 3:
                                Console.WriteLine("Bot: Scissors");
                                Console.WriteLine("Draw");
                                break;
                            default: break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (playerChoose != 0);

            // If statement
            /*if (playerChoose == 1) //rock
            {
                if (botChoose == 1)
                {
                    Console.WriteLine("Bot: Rock");
                    Console.Write("Draw");
                }
                else if (botChoose == 2)
                {
                    Console.WriteLine("Bot: Paper");
                    Console.Write("Bot win");
                }
                else if (botChoose == 3)
                {
                    Console.WriteLine("Bot: Scissors");
                    Console.Write("You win");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else if (playerChoose == 2) //paper
            {
                if (botChoose == 1)
                {
                    Console.WriteLine("Bot: Rock");
                    Console.Write("You win");
                }
                else if (botChoose == 2)
                {
                    Console.WriteLine("Bot: Paper");
                    Console.Write("Draw");
                }
                else if (botChoose == 3) 
                {
                    Console.WriteLine("Bot: Scissors");
                    Console.Write("Bot win");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else if (playerChoose == 3) //scissors
            {
                if (botChoose == 1)
                {
                    Console.WriteLine("Bot: Rock");
                    Console.Write("Bot win");
                }
                else if (botChoose == 2)
                {
                    Console.WriteLine("Bot: Paper");
                    Console.Write("You win");
                }
                else if (botChoose == 3)
                {
                    Console.WriteLine("Bot: Scissors");
                    Console.Write("Draw");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }*/
        }
    }
}