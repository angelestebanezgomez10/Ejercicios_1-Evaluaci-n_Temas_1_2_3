using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese una nota: ");
            string nota = Console.ReadLine();

            string ruta = "datos.txt";

            File.AppendAllText(ruta, $"{nombre},{nota}\n");
            Console.WriteLine("Nota guardada.");

            Console.WriteLine("\n Notas registradas ");
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                for (int i = 0; i < lineas.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {lineas[i]}");
                }
            }
            else
            {
                Console.WriteLine("No se ha registrado ninguna nota todavía.");
            }
        }
    }
}
