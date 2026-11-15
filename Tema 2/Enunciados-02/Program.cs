using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Directory.GetCurrentDirectory();
            Console.WriteLine($"Directorio actual: {ruta}");

            if (!Directory.Exists(ruta))
            {
                Console.WriteLine($"La carpeta {ruta} no existe.");
                return;
            }
            Console.WriteLine($"La carpeta {ruta} existe.");

            foreach (string archivo in Directory.EnumerateFiles(ruta , " *.cs"))
            {
                Console.Write(Path.GetFileName(archivo));
            }

            int total = 0;
            foreach (string ruta1 in Directory.EnumerateFiles(ruta, "*.*", SearchOption.AllDirectories))
            {
                Console.WriteLine(ruta1);
                total++;
            }

            Console.WriteLine($"\nTotal de ficheros encontrados: {total}");

        }
    }
}
