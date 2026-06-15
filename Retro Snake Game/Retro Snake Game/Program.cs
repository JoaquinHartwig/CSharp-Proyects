namespace Retro_Snake_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coord gridDimension = new Coord(50, 20); // 50 columnas 20 filas
            Coord snakePos = new Coord(10, 1);//posicion inicial de la cabeza de la serpiente
            Random rand = new Random();//Generación aleatoria (Random) maquina q genera numeros aleatorios 
            Coord applePos = new Coord(rand.Next(1, gridDimension.X - 1), rand.Next(1, gridDimension.Y - 1));// Genera la manzana
            int frameDelayMilli = 100;//Velocidad del juego
            Directioncs movementDirection = Directioncs.Down; //Guarda la dirreccion actual (solo almacena un valor) Mira hacia abajo
            List<Coord> SnakePosHistory = new List<Coord>();//Guarda la cola
            int tailLeng = 1;//Longitud de la cola 
            int score = 0;//Puntaje

            while(true) { //Jugar para siempre practicamente no hay ninguna condicion q impida q termine el juego,es decir un bucle infinito 
                Console.Clear();//Borra el frame anterior 
                Console.WriteLine("Score:" + score);//Mostrar score
                snakePos.ApplyMovementDirection(movementDirection);//Mover la cabeza 
                for (int y = 0; y < gridDimension.Y; y++) // Dibujar tablero a travez de bucles anidados  ( for )
                {
                    for (int x = 0; x < gridDimension.X; x++)

                    {

                        Coord currentCoord = new Coord(x, y); 
                        if (snakePos.Equals(currentCoord)|| SnakePosHistory.Contains(currentCoord)) // ¿Es la cabeza? o ¿Es una parte de la cola?
                            

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
                            Console.Write("a");// Sí si---

                        }
                        else if (x == 0 || y == 0 || x == gridDimension.X - 1 || y == gridDimension.Y - 1) //Dibujar paredes
                        {
                            Console.Write("#");// ¿Estoy en el borde? Si sí
                        }
                        else
                        {
                            Console.Write(" ");//Espacio vacio donde juega la serpiente
                        }

                    }
                    Console.WriteLine();
                }
                if (snakePos.Equals(applePos))//Comio la manzana ? la cabeza toco la Pos de la manzana?
                {
                    tailLeng++;//Cola crece
                    score++;//Aumenta score
                    applePos = new Coord(rand.Next(1, gridDimension.X - 1), rand.Next(1, gridDimension.Y - 1));//Cambia la Pos de la manzana a una aleatoria respetando los rangos (condiciones) dados
                }
                else if(snakePos.X==0 || snakePos.Y==0 || snakePos.X==gridDimension.X-1 || snakePos.Y==gridDimension.Y-1 || SnakePosHistory.Contains(snakePos)) {
                    score = 0;   //¿Murio? hay dos tipos de muerte choco contra la pared o contra si mismo 
                    tailLeng = 1; // Si ocurre reinicia 
                    snakePos = new Coord(15, 5);//Nueva posicion de la cabeza 
                    SnakePosHistory.Clear();//Borra toda la cola 
                    movementDirection = Directioncs.Down;//reinicia dirreción
                    continue;//sigue el juego no rompe el While 

                }
                  SnakePosHistory.Add(new Coord(snakePos.X, snakePos.Y)); 
                if (SnakePosHistory.Count > tailLeng)//esto controla q la cola no sea infinita 
                {
                    SnakePosHistory.RemoveAt(0);
                }
                 DateTime time = DateTime.Now;//Guarda el instante actual 
                while ((DateTime.Now - time).Milliseconds < frameDelayMilli) // Esperar 100 ms
                {
                    if(Console.KeyAvailable) //El jugador apreto alguna tecla?
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
