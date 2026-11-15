using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "ana", "luis", "marta", "pablo" };

            List<string> NombresEnMayusculas = nombres.Select(nombre => nombre.ToUpper()).ToList();
            Console.WriteLine("Nombres en mayúsculas:");
            foreach (var nombre in NombresEnMayusculas)
            {
                Console.WriteLine(nombre);
            }

            List<int> cantidadDeLetras = nombres.Select(nombre => nombre.Length).ToList();
            Console.WriteLine("Cantidad de letras de cada nombre:");

            foreach (int cantidad in cantidadDeLetras)
            {
                Console.WriteLine(cantidad);
            }

            List<string> Saludar = nombres.Select(nombre => "Hola, " + nombre + "!").ToList();
            foreach (string saludo in Saludar)
            {
                Console.WriteLine(saludo);
            }

            List<string>nombresMasDe4Letras=nombres
                .Where(nombre => nombre.Length > 4)
                .Select(nombre=>nombre.ToUpper()).ToList();
            Console.WriteLine("Nombres con más de 4 letras:");
            foreach (var nombre in nombresMasDe4Letras)
            {
                Console.WriteLine(nombre);
            }

        }
    }
}
