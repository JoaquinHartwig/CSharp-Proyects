using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    internal class GameState // Aqui almacenaremos la cuadricula de juego de 3x3 como una matriz de juego bidimensional
    {
        public Player[,] GameGrid {get; private set; } // Player[,] tablero;
        public Player CurrentPlayer { get; private set; }

        public int TurnsPassed { get; private set; } // Cuantos turnos han pasado 

        public bool GameOver { get; private set; } // Si el juego a terminado o no 

        public event Action<int , int > MoveMade;//Un evento (event) en C# es un mecanismo para que un objeto pueda decir: "¡Acaba de pasar algo! Si alguien está interesado, que reaccione."

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
        private bool CanMakeMove(int x,int y)
        {
            return !GameOver && GameGrid[x, y] == Player.None; //SI el juego todavia no termino y si la casilla esta vacia retorna verdadero es decir q el jugador puede marcar esa casilla

            //juego no ha terminado y casilla esta vacia
        }
    }
}
