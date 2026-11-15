using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C8_C9_04
{
    internal class Program
    {

        static void Saludar(string nombre, string idioma = "es")
        {

            if (idioma=="es")
            {
                Console.WriteLine($"Hola {nombre}");
            }
            else
            {
                Console.WriteLine($"Hello {nombre}");
            }
        }
        
        static void Main(string[] args)
        {

            Saludar("Maria", "es");
            Saludar("Pepe", "en");
        }
    }
}
