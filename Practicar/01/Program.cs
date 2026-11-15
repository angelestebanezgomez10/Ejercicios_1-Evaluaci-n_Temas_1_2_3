using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Path.Combine("datos", "informes", "resumen.final.txt");
            Console.WriteLine(Path.GetFileName(ruta));
            Console.WriteLine(Path.GetFileNameWithoutExtension(ruta));
            Console.WriteLine(Path.GetExtension(ruta));
            Console.WriteLine(Path.GetDirectoryName(ruta));


            Console.WriteLine(Path.ChangeExtension(ruta, "pdf"));

            if (File.Exists(ruta))
            {
                Console.WriteLine(ruta);
            }
        }
    }
}
