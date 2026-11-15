using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_01
{
    internal class Coche : Vehiculo
    {
        private int puertas;

        public Coche(string marca, string modelo, int anio, int puertas) : base(marca, modelo, anio)
        {
            this.puertas = puertas;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Puertas: " + this.puertas);
        }
    }
}
