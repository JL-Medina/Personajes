using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personajes
{
    public class Enemigo : Personaje
    {
        protected int vida;
        protected int nivel;

        public Enemigo (string name, int hp, int lvl)
        {
            nombre = name;
            vida = hp;  
            nivel = lvl;
            magia = 20;
            agilidad = 50;
            fuerza = 250;
        }

        public override int CalcularDanio()
        {
            return (fuerza + agilidad) * magia;
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
