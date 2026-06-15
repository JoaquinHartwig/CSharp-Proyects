namespace Retro_Snake_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord gridDimension = new Coord(50, 20);
            Coord snakePos = new Coord(10, 5);

            for (int y = 0; y < gridDimension.Y; y++)
            {
                for (int x = 0; x < gridDimension.X; x++)

                {
                    Coord currentCoord = new Coord(x, y);
                    if (x == snakePos.X &&
                                              y == snakePos.Y)
                    {
                        Console.Write("■");
                    }
                    else if (x == 0 || y == 0 || x == gridDimension.X - 1 || y == gridDimension.Y - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                  
                }
                Console.WriteLine();


            }
        }
    }
}
