using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Path.Combine("datos", "2DAM", "alumnos.csv");

            Console.WriteLine($"Ruta del archivo: {ruta}");
            Console.WriteLine($"Nombre del archivo: {Path.GetFileName(ruta)}");
            Console.WriteLine($"Nombre sin extension: {Path.GetFileNameWithoutExtension(ruta)}");
            Console.WriteLine($"Extension del archivo: {Path.GetExtension(ruta)}");
            Console.WriteLine($"Directorio del archivo: {Path.GetDirectoryName(ruta)}");


            string ruta2=Path.ChangeExtension("datos/2DAM/alumnos.csv", ".json");

            Console.WriteLine($"Ruta del programa:{Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Ruta absoluta de: {Path.GetFullPath(ruta2)}");

            string[] rutas = { "foto.PNG", "notas.txt", "logo.gif", "informe.pdf", "playa.Jpg", "LEEME" };

            foreach(string ruta3 in rutas)
            {
               
                string extension = Path.GetExtension(ruta3).ToLower();
                bool esImagen = extension == ".png" || extension == ".jpg" || extension == ".gif";
                Console.WriteLine($"Archivo: {ruta3}, es imagen: {esImagen}");
            }


        }
    }
}
