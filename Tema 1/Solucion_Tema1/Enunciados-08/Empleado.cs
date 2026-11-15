using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_08
{
    internal class Empleado
    {
        private string nombre;
        private decimal SalarioBase;

        public Empleado(string nombre, decimal salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public string Nombre { get; set; }

        public decimal Salario { get; set; }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
