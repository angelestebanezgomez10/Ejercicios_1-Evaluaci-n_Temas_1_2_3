using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void InformeCarpeta(string carpeta)
        {
            long total = 0;
            foreach(string ficheros in Directory.EnumerateFiles(carpeta))
            {
                FileInfo informacion = new FileInfo(carpeta);
                Console.WriteLine($"Nombre: {informacion.Name}");
                Console.WriteLine($"Tamaño: {informacion.Length}");
                Console.WriteLine($"Última modificación: {informacion.LastWriteTime}");
                total += informacion.Length;
                Console.WriteLine(total);
            }
        }
        static void Main(string[] args)
        {
            string carpeta = "datos";


        }
    }
}
