using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personajes
{
    public static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            foreach (Personaje pj in personajes)
            {
                pj.Atacar();
            }
        }
        public static void MoverFichas(Personaje personajes, int movimientosX, int movimientosY)
        {
            personajes.MoverseEjeX(movimientosX);
            personajes.MoverseEjeY(movimientosY);
        }
    }
}
