using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_R_W_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "saludo.txt";
            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "holaa.txt");
            }
            using (StreamReader lector = new StreamReader(ruta))
            {
                string? linea;
                while((linea=lector.ReadLine())!= null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
    }
}
