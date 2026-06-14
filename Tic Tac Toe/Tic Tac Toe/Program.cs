namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();
            game.GameEnded += result =>
            {
                DrawBoard(game);

                if (result.Winner == Player.None)
                {
                    Console.WriteLine("Draw!");
                }
                else
                {
                    Console.WriteLine($"{result.Winner} wins!");
                }
            };
            while (!game.GameOver)
            {
                DrawBoard(game);

                Console.WriteLine($"Current Player: {game.CurrentPlayer}");

                Console.Write("Row (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write("Column (0-2): ");
                int col = int.Parse(Console.ReadLine());

                game.MakeMove(row, col);
            }
        }
        static void DrawBoard(GameState game) //Metodo q dibuja el tablero
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Player p = game.GameGrid[i, j];

                    char symbol =
                        p == Player.X ? 'X' :
                        p == Player.O ? 'O' : '-';

                    Console.Write(symbol + " ");
                }

                Console.WriteLine();
            }
        }

    }


}
