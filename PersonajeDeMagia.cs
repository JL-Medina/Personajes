using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string name, int strength, int agility, int magic)
        {
            nombre = name;
            fuerza = strength;
            agilidad = agility;
            magia = magic;
        }
        public PersonajeDeMagia(string name, int strength, int agility)
        {
            nombre = name;
            fuerza = strength;
            agilidad = agility;
            magia = 60;
        }
        public override int CalcularDanio()
        {
            return fuerza + agilidad + magia * 4;
        }
        public override void Atacar()
        {
            int x = CalcularDanio();
            Console.WriteLine($"{ nombre} hizo { x} de daño gracias a su magia");
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
