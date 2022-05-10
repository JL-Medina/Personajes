using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    
    internal class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string name, int strength, int agility, int magic)
        {
            nombre = name;
            fuerza = 100;    
            agilidad = agility;
            magia = magic;
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

        public override void MoverseEjeX()
        {
            throw new NotImplementedException();
        }

        public override void MoverseEjeY()
        {
            throw new NotImplementedException();
        }
    }
}
