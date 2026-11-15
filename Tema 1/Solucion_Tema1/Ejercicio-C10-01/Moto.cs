using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_01
{
    internal class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(string marca, string modelo, int anio, int cilindrada) : base(marca, modelo, anio)
        {
            this.cilindrada = cilindrada;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Cilindrada: " + this.cilindrada + "cc");
        }
    }
}
