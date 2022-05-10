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
        public Enemigo(string name, int strength, int agility, int magic)
        {
            nombre = name;
            fuerza = strength;
            agilidad = agility;
            magia = magic;
        }

        public override void Atacar()
        {
            throw new NotImplementedException();
        }

        public override int CalcularDanio()
        {
            throw new NotImplementedException();
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
