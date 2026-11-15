using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_02
{
    internal class EmpleadoPorHoras : Empleado
    {
        private int horas;
        private double precioHora;

        public EmpleadoPorHoras(string nombre, int horas, double precioHora) : base(nombre)
        {
            this.horas = horas;
            this.precioHora = precioHora;
        }

        public override double CalcularSalario()
        {
            return horas * precioHora;
        }
    }
}
