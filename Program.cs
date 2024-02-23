
using System.Security.Cryptography;

namespace C__Player_s_Guide___Tic_Tac_Toe 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 3);

            int rows = 3;
            int columns = 3;

            string[,] table = new string[rows, columns];

            table[0, 0] = "-";
            table[0, 1] = "-";
            table[0, 2] = "-";
            table[1, 0] = "-";
            table[1, 1] = "-";
            table[1, 2] = "-";
            table[2, 0] = "-";
            table[2, 1] = "-";
            table[2, 2] = "-";

            while (true)
            {
                Square.VerifyIfWinOrDraw(table);
                Console.Clear();
                Square.PrintMatrix(table);

                try
                {
                    Console.WriteLine("Player 1 (X) - Type the position: ");
                    int positionP1 = int.Parse(Console.ReadLine());
                    Square.VerifyPosition(positionP1);

                    if (positionP1 == 1)
                    {
                        table[2, 0] = "X";

                    }
                    else if (positionP1 == 2)
                    {
                        table[2, 1] = "X";
                    }
                    else if (positionP1 == 3)
                    {
                        table[2, 2] = "X";
                    }
                    else if (positionP1 == 4)
                    {
                        table[1, 0] = "X";
                    }
                    else if (positionP1 == 5)
                    {
                        table[1, 1] = "X";
                    }
                    else if (positionP1 == 6)
                    {
                        table[1, 2] = "X";
                    }
                    else if (positionP1 == 7)
                    {
                        table[0, 0] = "X";
                    }
                    else if (positionP1 == 8)
                    {
                        table[0, 1] = "X";
                    }
                    else if (positionP1 == 9)
                    {
                        table[0, 2] = "X";
                    }
                }
                catch(System.FormatException e) 
                { 
                    Console.WriteLine("Invalid Type! Write a number");
                    Console.ReadLine();
                }

                Square.VerifyIfWinOrDraw(table);

                Console.Clear();
                Square.PrintMatrix(table);


                try
                {
                    Console.WriteLine("Player 2 (O) - Type the position: ");
                    int positionP2 = int.Parse(Console.ReadLine());
                    Square.VerifyPosition(positionP2);

                    if (positionP2 == 1)
                    {
                        table[2, 0] = "O";

                    }
                    else if (positionP2 == 2)
                    {
                        table[2, 1] = "O";
                    }
                    else if (positionP2 == 3)
                    {
                        table[2, 2] = "O";
                    }
                    else if (positionP2 == 4)
                    {
                        table[1, 0] = "O";
                    }
                    else if (positionP2 == 5)
                    {
                        table[1, 1] = "O";
                    }
                    else if (positionP2 == 6)
                    {
                        table[1, 2] = "O";
                    }
                    else if (positionP2 == 7)
                    {
                        table[0, 0] = "O";
                    }
                    else if (positionP2 == 8)
                    {
                        table[0, 1] = "O";
                    }
                    else if (positionP2 == 9)
                    {
                        table[0, 2] = "O";
                    }
                }catch (System.FormatException e)
                {
                    Console.WriteLine("Invalid Type! Write a number");
                    Console.ReadLine();
                }

                Console.Clear();
                Square.PrintMatrix(table);
            }

        }

    }     
}
