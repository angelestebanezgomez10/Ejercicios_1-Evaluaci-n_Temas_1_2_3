using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFicheros = 0;
            string ruta = Directory.GetCurrentDirectory();

            foreach (string carpetas in Directory.EnumerateFiles(ruta, "*cs")){

                Console.WriteLine(Path.GetFileName(carpetas));
            }

            foreach (string carpetas1 in Directory.EnumerateFiles(ruta, "*", SearchOption.AllDirectories))
            {
                Console.WriteLine(carpetas1);
                totalFicheros++;

            }
            
            foreach(string carpetas2 in Directory.EnumerateDirectories(ruta)){
                Console.WriteLine($"{ruta}{Path.GetFileName(carpetas2)}");
            }
            Console.WriteLine($"Fciheros totales: {totalFicheros}");
        }
    }
}