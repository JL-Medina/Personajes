using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    
    internal class PersonajeDeFuerza : Personaje
    {

        public PersonajeDeFuerza(string name, int agility, int magic)
        {
            this.nombre = name;
            this.fuerza = 100;
            this.agilidad = agility;
            this.magia = magic;
        }

        public override int CalcularDanio()
        {
            return fuerza * (agilidad/2) + magia;
        }
        public override void Atacar()
        {
            int x = CalcularDanio();
            Console.WriteLine($"{ nombre} hizo { x} de daño");
        }

        public override void MoverseEjeX(int movimientos)
        {
            if (movimientos > 0)
            {
                Console.WriteLine($"{nombre} se movio a la derecha {movimientos} casillas");
            }
            else if (movimientos < 0)
            {
                Console.WriteLine($"{nombre} se movio a la izquierda {movimientos * -1} casillas");
            }
            else
            {
                Console.WriteLine($"{nombre} no se movió en el eje X");
            }
        }

        public override void MoverseEjeY(int movimientos)
        {
            if (movimientos > 0)
            {
                Console.WriteLine($"{nombre} se movio hacia arriba {movimientos} casillas");
            }
            else if (movimientos < 0)
            {
                Console.WriteLine($"{nombre} se movio hacia abajo {movimientos * -1} casillas");
            }
            else
            {
                Console.WriteLine($"{nombre} no se movió en el eje Y");
            }
        }
    }
}
