using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carpeta = "taller";
            string ruta = Path.Combine(carpeta, "entrada.txt");
            string copia = Path.Combine(carpeta, "entrada_copia.txt");
            string salida = Path.Combine(carpeta, "salida.txt");

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);



            }
            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta , "Linea 1, Linea 2, Linea 3");
            }

            File.Copy(ruta, copia, overwrite: true);
            File.Move(ruta, salida, overwrite: true);

            FileInfo info = new FileInfo(salida);
            Console.WriteLine($"Nombre: {info.Name}");
            Console.WriteLine($"Tamaño:{info.Length}");

        }
    }
}
