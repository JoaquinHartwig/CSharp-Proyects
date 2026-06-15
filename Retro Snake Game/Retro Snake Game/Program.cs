namespace Retro_Snake_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord gridDimension = new Coord(50, 20);
            Coord snakePos = new Coord(10, 1);
            Random rand = new Random();//Generación aleatoria (Random)
            Coord applePos = new Coord(rand.Next(1, gridDimension.X - 1), rand.Next(1, gridDimension.Y - 1));
            int frameDelayMilli = 100;
            Directioncs movementDirection = Directioncs.Down; //Guarda la dirreccion actual (solo almacena un valor)
            List<Coord> SnakePos = new List<Coord>();
            int tailLeng = 1;

            while(true) {
                Console.Clear();
                snakePos.ApplyMovementDirection(movementDirection);
                for (int y = 0; y < gridDimension.Y; y++)
                {
                    for (int x = 0; x < gridDimension.X; x++)

                    {

                        Coord currentCoord = new Coord(x, y);
                        if (snakePos.Equals(currentCoord))
                        {
                            Console.Write("■");
                        }
                        /* if (x == snakePos.X &&
                                    y == snakePos.Y)
                         {
                             Console.Write("■");
                         }
                        */
                        else if (applePos.Equals(currentCoord)) //¿La casilla que estoy dibujando es la misma donde está la manzana?
                        {
                            Console.Write("a");
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
                 DateTime time = DateTime.Now;
                while ((DateTime.Now - time).Milliseconds < frameDelayMilli)
                {
                    if(Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.A:
                                movementDirection = Directioncs.Left; break;

                            case ConsoleKey.D:
                                movementDirection = Directioncs.Right; break;
                            case ConsoleKey.W:
                                movementDirection = Directioncs.Up; break;
                            case ConsoleKey.S:
                                movementDirection = Directioncs.Down; break;

                        }    
                    }
                }


            }
        }
    }
}
