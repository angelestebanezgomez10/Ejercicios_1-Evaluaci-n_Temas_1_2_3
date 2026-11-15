using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Empleado("Juan", 1000));
            empleados.Add(new Encargado("María", 1500, 500));

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}, Salario: {empleado.CalcularSalario()}");
            }
            List<Encargado> encargados = empleados.OfType<Encargado>().ToList();
            Console.WriteLine($"\nNúmero de encargados en la plantilla: {encargados.Count}");
        }
    }
}
