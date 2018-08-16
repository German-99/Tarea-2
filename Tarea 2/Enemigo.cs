using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Enemigo
    {
        //Auto-propierties
        public int PosiciónX { get; set; }
        public int PosiciónY { get; set; }

        // Propierties
        private int _PuntosGanados;
        public int PuntosGanados
        {
            get
            {
                return _PuntosGanados;
            }
            set
            {
                if(PuntosGanados < 100)
                {
                    PuntosGanados = 100;
                }
            }

        }
        //Funciones
        public void moverse()
        {

        }
        public void disparar()
        {

        }
        public void explotar()
        {

        }
    }
}
