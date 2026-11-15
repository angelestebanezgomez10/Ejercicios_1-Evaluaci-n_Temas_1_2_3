using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C8_C9_03
{
    internal class Program
    {

        static bool esMayordeEdad(int edad)
        {
            return edad >= 18;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(esMayordeEdad(18));
            Console.WriteLine(esMayordeEdad(4));
            Console.WriteLine(esMayordeEdad(20));
        }
    }
}