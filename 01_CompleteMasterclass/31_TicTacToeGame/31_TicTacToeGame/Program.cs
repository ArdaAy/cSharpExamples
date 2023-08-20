using System;

namespace _31_TicTacToeGame
{
    class Program
    {
        static int[,] gameTable =
        {
            {0,0,0},
            {0,0,0},
            {0,0,0}
        };

        static bool gameOver = false;
        static string winner = null;
        static void Main(string[] args)
        {
            while (true)
            {
                if (!gameOver)
                {
                    game();
                }
                else
                {
                    Console.Clear();
                    printGame();
                    Console.WriteLine("The winner is : " + winner);
                    break;
                }
            }
            
            /*
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  1  |  2  |  3  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  4  |  5  |  6  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  7  |  8  |  9  ");
            Console.WriteLine("     |     |     ");
            */
        }

        static void game()
        {
            Console.Clear();
            printGame();
            int input = 0;
            bool isOkey = false;
            do
            {
                Console.Write("Player 1 Enter: ");
                input = int.Parse(Console.ReadLine());
                isOkey = isEmptyArea(input);
                if (!isOkey)
                {
                    Console.WriteLine("The area is taken.");
                }

            } while ((input < 1 && input > 9) || !isOkey);

            addInputValue(input, 1);

            Checker(gameTable, out winner);
            if (!gameOver)
            {
                Console.Clear();
                printGame();
                

                input = 0;
                isOkey = false;
                do
                {
                    Console.Write("Player 2 Enter: ");
                    input = int.Parse(Console.ReadLine());
                    isOkey = isEmptyArea(input);
                    if (!isOkey)
                    {
                        Console.WriteLine("The area is taken.");
                    }

                } while ((input < 1 && input > 9) || !isOkey);

                addInputValue(input, 2);
                Checker(gameTable, out winner);
            }
        }
        
        static bool isEmptyArea(int value)
        {
            switch (value)
            {
                case 1:
                    if (gameTable[0, 0] == 0)   return true;
                    else                        return false;
                case 2:
                    if (gameTable[0, 1] == 0)   return true;
                    else                        return false;
                case 3:
                    if (gameTable[0, 2] == 0)   return true;
                    else                        return false;
                case 4:
                    if (gameTable[1, 0] == 0)   return true;
                    else                        return false;
                case 5:
                    if (gameTable[1, 1] == 0)   return true;
                    else                        return false;
                case 6:
                    if (gameTable[1, 2] == 0)   return true;
                    else                        return false;
                case 7:
                    if (gameTable[2, 0] == 0)   return true;
                    else                        return false;
                case 8:
                    if (gameTable[2, 1] == 0)   return true;
                    else                        return false;
                case 9:
                    if (gameTable[2, 2] == 0)   return true;
                    else                        return false;
                default:
                    return false;
            }
        }

        static void addInputValue(int value, int player)
        {
            switch (value)
            {
                case 1:
                    gameTable[0, 0] = player == 1 ? 1 : 2;
                    break;
                case 2:
                    gameTable[0, 1] = player == 1 ? 1 : 2;
                    break;
                case 3:
                    gameTable[0, 2] = player == 1 ? 1 : 2;
                    break;
                case 4:
                    gameTable[1, 0] = player == 1 ? 1 : 2;
                    break;
                case 5:
                    gameTable[1, 1] = player == 1 ? 1 : 2;
                    break;
                case 6:
                    gameTable[1, 2] = player == 1 ? 1 : 2;
                    break;
                case 7:
                    gameTable[2, 0] = player == 1 ? 1 : 2;
                    break;
                case 8:
                    gameTable[2, 1] = player == 1 ? 1 : 2;
                    break;
                case 9:
                    gameTable[2, 2] = player == 1 ? 1 : 2;
                    break;
            }
        }

        static void printGame()
        {
            string area1 = gameTable[0, 0] == 0 ? "1" : gameTable[0, 0] == 1 ? "X" : "O";
            string area2 = gameTable[0, 1] == 0 ? "2" : gameTable[0, 1] == 1 ? "X" : "O";
            string area3 = gameTable[0, 2] == 0 ? "3" : gameTable[0, 2] == 1 ? "X" : "O";
            string area4 = gameTable[1, 0] == 0 ? "4" : gameTable[1, 0] == 1 ? "X" : "O";
            string area5 = gameTable[1, 1] == 0 ? "5" : gameTable[1, 1] == 1 ? "X" : "O";
            string area6 = gameTable[1, 2] == 0 ? "6" : gameTable[1, 2] == 1 ? "X" : "O";
            string area7 = gameTable[2, 0] == 0 ? "7" : gameTable[2, 0] == 1 ? "X" : "O";
            string area8 = gameTable[2, 1] == 0 ? "8" : gameTable[2, 1] == 1 ? "X" : "O";
            string area9 = gameTable[2, 2] == 0 ? "9" : gameTable[2, 2] == 1 ? "X" : "O";

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", area1, area2, area3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", area4, area5, area6);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", area7, area8, area9);
            Console.WriteLine("     |     |     ");
        }

        public static bool Checker(int[,] board, out string winner)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == 1 && board[i, 1] == 1 && board[i, 2] == 1)
                {
                    winner = "Player 1";
                    gameOver = true;
                    return true;
                }
                else if (board[i, 0] == 2 && board[i, 1] == 2 && board[i, 2] == 2)
                {
                    winner = "Player 2";
                    gameOver = true;
                    return true;
                }
                else if (board[0, i] == 2 && board[1, i] == 2 && board[2, i] == 2)
                {
                    winner = "Player 2";
                    gameOver = true;
                    return true;
                }
                else if (board[0, i] == 1 && board[1, i] == 1 && board[2, i] == 1)
                {
                    winner = "Player 1";
                    gameOver = true;
                    return true;
                }
            }

            if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
            {
                winner = "Player 1";
                gameOver = true;
                return true;
            }
            else if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2)
            {
                winner = "Player 2";
                gameOver = true;
                return true;
            }
            winner = null;
            return false;
        }
    }
}
