using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz;

namespace Personajes
{
    public abstract class Personaje : IMoverse
    {
        protected string nombre;
        protected int fuerza;
        protected int agilidad;
        protected int magia;

        public abstract int CalcularDanio();
        public abstract void Atacar();
        public abstract void MoverseEjeX();
        public abstract void MoverseEjeY();


    }
}
