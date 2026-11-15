using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_02
{
    internal abstract class Empleado
    {
        private String nombre;

        public String Nombre{ get;set;}

        public Empleado(String nombre)
        {
            this.nombre = nombre;
        }

        public abstract double CalcularSalario();

        public void MostrarNomina()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Salario: " + CalcularSalario());
        }
    }
}
