using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Introduzca su año de nacimiento: ");
            string año = Console.ReadLine();

            if(!int.TryParse(año, out int año2))
            {
                Console.WriteLine("Por favor, introduzca un año válido.");
                return;
            }

            Console.Write("Introduzca su altura en metros: ");
            string altura = Console.ReadLine();

            if(!decimal.TryParse(altura, out decimal altura2))
            {
                Console.WriteLine("Por favor, introduzca una altura válida.");
                return;
            }

            int anioactual = DateTime.Now.Year;
            int edad = anioactual - año2;

            Console.WriteLine($"Hola, {nombre}. Tienes {edad} años y mides {altura2} metros.");
        }
    }
}
