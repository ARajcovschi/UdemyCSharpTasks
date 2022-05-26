using System;

namespace TicTacToe
{
    class Program
    {
        static string playerSignature;
        static string[,] table = new string[,]
            {
                    {"1", "2", "3"},
                    {"4", "5", "6"},
                    {"7", "8", "9"}
            };
        static void Main(string[] args)
        {

            FirstPlayerMove();
        }

        public static void SetField(string[,] array)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array[0, 0], array[0, 1], array[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array[1, 0], array[1, 1], array[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array[2, 0], array[2, 1], array[2, 2]);
            Console.WriteLine("   |   |   ");
        }
        public static bool Checker(string[,] board)
        {
            // here we perform horizontal and vertical checks
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            // here diagonal checks 
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;
            return false;
        }

        public static int SlotSelection()
        {
            int num;
            string fieldNum = Console.ReadLine();
            if (fieldNum.Length == 1)
            {
                bool success = int.TryParse(fieldNum, out num);
                if (success)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Please input correct value");
                    SlotSelection();
                }
            }
            return 0;
        }


        public static void FirstPlayerMove()
        {
            playerSignature = "X";
            Console.WriteLine("Player 1: Choose your field!");
            ChangeSlot(table);
            SetField(table);
            if (Checker(table))
            {
                Console.WriteLine("First Player Won!!!");
            }
            else
            {
                SecondPlayerMove();
            }
        }
        public static void SecondPlayerMove()
        {
            playerSignature = "O";
            Console.WriteLine("Player 2: Choose your field!");
            ChangeSlot(table);
            SetField(table);
            if (Checker(table))
            {
                Console.WriteLine("Second Player Won!!!");
            }
            else
            {
                FirstPlayerMove();
            }
        }

        public static void ChangeSlot(string[,] array)
        {
            int num = SlotSelection();

            switch (num)
            {
                case 1:
                    if (array[0, 0] != "X" && array[0, 0] != "O")
                        array[0, 0] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 2:
                    if (array[0, 1] != "X" && array[0, 1] != "O")
                        array[0, 1] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 3:
                    if (array[0, 2] != "X" && array[0, 2] != "O")
                        array[0, 2] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 4:
                    if (array[1, 0] != "X" && array[1, 0] != "O")
                        array[1, 0] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 5:
                    if (array[1, 1] != "X" && array[1, 1] != "O")
                        array[1, 1] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 6:
                    if (array[1, 2] != "X" && array[1, 2] != "O")
                        array[1, 2] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 7:
                    if (array[2, 0] != "X" && array[2, 0] != "O")
                        array[2, 0] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 8:
                    if (array[2, 1] != "X" && array[2, 1] != "O")
                        array[2, 1] = playerSignature;
                    else
                        SlotSelection();
                    break;
                case 9:
                    if (array[2, 2] != "X" && array[2, 2] != "O")
                        array[2, 2] = playerSignature;
                    else
                        SlotSelection();
                    break;
                default:
                    break;
            }
        }
    }
}