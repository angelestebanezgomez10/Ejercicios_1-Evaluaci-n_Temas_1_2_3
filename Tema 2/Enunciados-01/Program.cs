using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carpeta="datos";
            string ficheroSaludo = Path.Combine(carpeta, "saludo.txt");
            string ficheroCopia = Path.Combine(carpeta, "copia.txt");

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
                Console.WriteLine($"Se ha creado la carpeta {carpeta}");
            }
            else
            {
                Console.WriteLine($"La carpeta {carpeta} ya existe");
            }

            if(!File.Exists(ficheroSaludo))
            {
                using (StreamWriter escritor = new StreamWriter(ficheroSaludo))
                {
                    escritor.WriteLine("Hola, Acceso a Datos!");
                }
                Console.WriteLine($"Se ha creado el fichero {ficheroSaludo}");
            }
            else
            {
                Console.WriteLine($"El fichero {ficheroSaludo} ya existe");
            }

            File.Copy(ficheroSaludo, ficheroCopia, overwrite:true);
            Console.WriteLine($"Se ha creado el fichero {ficheroCopia}");

            FileInfo fileInfo = new FileInfo(ficheroCopia);
            Console.WriteLine($"Tamaño: {fileInfo.Length} bytes");
            
            FileInfo fileInfo1 = new FileInfo(ficheroSaludo);
            Console.WriteLine($"Tamaño: {fileInfo1.Length} bytes");


            File.Delete(ficheroCopia);
            Console.WriteLine($"Se ha eliminado el fichero {ficheroCopia}");
        }
    }
}
