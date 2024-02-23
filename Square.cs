
namespace C__Player_s_Guide___Tic_Tac_Toe
{
    internal class Square
    {

        public static void VerifyIfWinOrDraw(string[,] matrix)
        {
            //O
            if (matrix[2, 0] == "O" && matrix[2, 1] == "O" && matrix[2, 2] == "O") //1 2 3
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);

            }
            else if (matrix[1, 0] == "O" && matrix[1, 1] == "O" && matrix[1, 2] == "O") //4 5 6
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[0, 0] == "O" && matrix[0, 1] == "O" && matrix[0, 2] == "O") //7 8 9
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 0] == "O" && matrix[1, 1] == "O" && matrix[0, 2] == "O") //1 5 9
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 2] == "O" && matrix[1, 1] == "O" && matrix[0, 0] == "O") //3 5 7
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 0] == "O" && matrix[1, 0] == "O" && matrix[0, 0] == "O") //1 4 7
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 2] == "O" && matrix[1, 2] == "O" && matrix[0, 2] == "O") //3 6 9
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 1] == "O" && matrix[1, 1] == "O" && matrix[0, 1] == "O") //2 5 8
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'O' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //X 
            if (matrix[2, 0] == "X" && matrix[2, 1] == "X" && matrix[2, 2] == "X") //1 2 3
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);

            }
            else if (matrix[1, 0] == "X" && matrix[1, 1] == "X" && matrix[1, 2] == "X") //4 5 6
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[0, 0] == "X" && matrix[0, 1] == "X" && matrix[0, 2] == "X") //7 8 9
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 0] == "X" && matrix[1, 1] == "X" && matrix[0, 2] == "X") //1 5 9
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 2] == "X" && matrix[1, 1] == "X" && matrix[0, 0] == "X") //3 5 7
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 0] == "X" && matrix[1, 0] == "X" && matrix[0, 0] == "X") //1 4 7
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 2] == "X" && matrix[1, 2] == "X" && matrix[0, 2] == "X") //3 6 9
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (matrix[2, 1] == "X" && matrix[1, 1] == "X" && matrix[0, 1] == "X") //2 5 8
            {
                Console.Clear();
                PrintMatrix(matrix);
                Console.WriteLine("The player using the 'X' WON!!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public static void PrintMatrix(string[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }
        }

        public static void VerifyPosition(int position)
        {
            try
            {
                if (position < 1 | position > 9)
                {
                    throw new IndexOutOfRangeException("\nInvalid Position! The avaiable positions is: 1 to 9");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
        }

        //Terminar depois
        
    }
}
