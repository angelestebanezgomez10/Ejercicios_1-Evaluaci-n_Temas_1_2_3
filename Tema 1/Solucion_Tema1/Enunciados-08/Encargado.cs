using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_08
{
    internal class Encargado : Empleado
    {
        private string nombre;
        private decimal Plus;
        private decimal SalarioBase;

        public Encargado(string nombre, decimal salarioBase, decimal plus) : base(nombre, salarioBase)
        {
            Plus = plus;
        }

        public string Nombre { get; set; }

        public decimal Salario { get; set; }

        public override decimal CalcularSalario()
        {
            return SalarioBase + Plus;
        }
    }
}
