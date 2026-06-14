using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class WinInfo //esta clase da informacion de como gano el  jugador en una partida 
    {
        public WinType type { get; set; } //Como gano?
        public int number { get; set; }//que fila columna fue 
    }
}
