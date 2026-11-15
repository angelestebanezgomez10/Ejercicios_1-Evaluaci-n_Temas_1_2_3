using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new EmpleadoFijo("Juan", 1000, 200));
            empleados.Add(new EmpleadoFijo("Ana", 1200, 150));
            empleados.Add(new EmpleadoPorHoras("María", 40, 15));
            empleados.Add(new EmpleadoPorHoras("Pedro", 30, 20));

            decimal total = 0;

            foreach (Empleado x in empleados)
            {
                x.MostrarNomina();
                total += (decimal)x.CalcularSalario();
            }

            Console.WriteLine($"Total de salarios: {total}");
            
        }
    }
}
