using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_02
{
    internal class EmpleadoFijo : Empleado
    {
        private double sueldoBase;
        private double complemento;

        public EmpleadoFijo(string nombre, double sueldoBase, double complemento) : base(nombre)
        {
            this.sueldoBase = sueldoBase;
            this.complemento = complemento;
        }

        public override double CalcularSalario()
        {
            return sueldoBase + complemento;
        }
    }
}
