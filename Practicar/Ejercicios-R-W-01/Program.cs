using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_R_W_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter escritor = new StreamWriter("saludo.txt"))
            {
                escritor.WriteLine("Hola");
                escritor.WriteLine("Esto es una prueba");
                escritor.WriteLine("Adios");

            }
            Console.WriteLine("Fichero Creado");

        }
    }
}
