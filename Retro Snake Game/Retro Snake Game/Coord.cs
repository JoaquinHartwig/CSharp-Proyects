using System;
using System.Collections.Generic;
using System.Text;

namespace Retro_Snake_Game
{
    internal class Coord // Representa una coordenada
    {
        private int x; //Estos atributos privados guardan los valores reales
        private int y;

        public int X { get { return x; } } // Las propeidades permite leerlos desde afuera
        public int Y { get { return y; } }

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType())) // Si obj es null retorna falso
                return false; // !GetType().Equals(obj.GetType())) ¿Son del mismo tipo? los dos son coords?

            Coord other = (Coord)obj;// Casting: convierte object en Coord
            return x == other.x && y == other.y; // ¿Los X son iguales? y los Y son iguales si es q si retorna true
        }
        /*a.x = 10
         b.x = 10
         a.y = 5
         b.y = 5*/

        public void ApplyMovementDirection(Directioncs direction)
        {
            switch (direction)
            {
                case Directioncs.Left:
                    x--;
                    break;
                case Directioncs.Right:
                    x++;
                    break;
                case Directioncs.Up:
                    y--;
                    break;
                case Directioncs.Down:
                    y++;
                    break;


            }

        }

    }
}

