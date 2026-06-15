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

        public Coord (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    
       }

    }

