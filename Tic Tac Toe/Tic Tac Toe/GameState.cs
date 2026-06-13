using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    internal class GameState // Aqui almacenaremos la cuadricula de juego de 3x3 como una matriz de juego bidimensional
    {
        public Player[,] GameGrid { get; private set; } // Player[,] tablero;
        public Player CurrentPlayer { get; private set; }

        public int TurnsPassed { get; private set; } // Cuantos turnos han pasado 

        public bool GameOver { get; private set; } // Si el juego a terminado o no 

        public event Action<int, int> MoveMade;//Un evento (event) en C# es un mecanismo para que un objeto pueda decir: "¡Acaba de pasar algo! Si alguien está interesado, que reaccione."

        /*Jugador muere
                ↓
       Avisa automáticamente
               ↓
    Se ejecutan las acciones necesarias*/

        //void Algo(int x, int y) =  Action<int , int >  Action es un delegado ya creado por .NET.
        //{
        //}

        public event Action<GameResultcs> GameEnded;
        public event Action GameRestarted;

        public GameState()
        {
            GameGrid = new Player[3, 3];
            CurrentPlayer = Player.X; //Generalmente el primer turno del jugador comienza con X
            TurnsPassed = 0;// Para mayor claridad
            GameOver = false;



        }
        private bool CanMakeMove(int x, int y)
        {
            return !GameOver && GameGrid[x, y] == Player.None; //SI el juego todavia no termino y si la casilla esta vacia retorna verdadero es decir q el jugador puede marcar esa casilla

            //juego no ha terminado y casilla esta vacia
        }
        private bool IsGrifFull()//La cuadricula debe estar llena si solo si han pasado nueve turnos
        {
            return TurnsPassed == 9;// Si pasan 9 turnos devuelve true
        }

        private void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == Player.X ? Player.O : Player.X;
        }

        //Tambien debemos saber cuando un jugador gano la partida entonces...

        private bool AreSquaredmarked((int, int)[] squares, Player player)
        {
            foreach ((int x, int y) in squares)
            {
                if (GameGrid[x, y] != player) //Verifica si un jugador hizo el tres en raya... Perfección 
                {
                    return false;
                }

            }
            return true; //"¿Todas estas posiciones están marcadas por este jugador?"

            /*Recibe:
          - Un arreglo de coordenadas (Arreglo de tuplas)
              -Un jugador (X u O)

                     Devuelve:
                 - true o false*/

        }

        private bool DidMoveWin(int x, int y, out WinInfo wininfo)
        { //Metodo para verificar si un movimiento gano la partida 

            {
                (int, int)[] row = new[] { (x, 0), (x, 1), (x, 2) };
                (int, int)[] colomn = new[] { (0, y), (1, y), (2, y) };
                (int, int)[] mainDiag = new[] { (0, 0), (1, 1), (2, 2) };
                (int, int)[] antiDiag = new[] { (0, 2), (1, 1), (2, 0) };//Si cada una de las casillas estan marcadas el jugador actual a ganado
                //Por lo tanto usaremos este metodo para saber si el jugador ha ganado la partida  

                if (AreSquaredmarked(row, CurrentPlayer))
                {
                    wininfo = new WinInfo { type = WinType.Row, number = x };
                    return true;

                }
                if (AreSquaredmarked(colomn, CurrentPlayer))
                {
                    wininfo = new WinInfo { type = WinType.Row, number = y };
                    return true;
                }
                if (AreSquaredmarked(mainDiag, CurrentPlayer))
                {
                    wininfo = new WinInfo { type = WinType.MainDiagonal };
                    return true;

                }
                if (AreSquaredmarked(antiDiag, CurrentPlayer))

                {
                    wininfo = new WinInfo { type = WinType.AntiDiagonal };
                    return true;
                }
                //Si pasamos estas 4 condiciones sin devolver true entonces el movimiento no fue ganador
                wininfo = null;
                return false;
            
            }


        }
    }
}
