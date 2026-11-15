using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C1_C2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("--- Parte A ---");

            using (RecursoDemo recurso = new RecursoDemo("Bloque"))
            {
                recurso.Usar();
            }
            Console.WriteLine("Después del bloque using");

            
            Console.WriteLine();
            try
            {
                using (RecursoDemo recurso = new RecursoDemo("Excepción"))
                {
                    recurso.Usar();
                    throw new InvalidOperationException("Fallo a propósito");
                }   
            }
            catch (InvalidOperationException ex)
            {
                
                Console.WriteLine($"Capturada: {ex.Message}");
            }

            
            Console.WriteLine();
            Console.WriteLine("--- Parte B ---");

            string ruta = "diario.txt";

            
            using (StreamWriter escritor = new StreamWriter(ruta))
            {
                escritor.WriteLine("Lunes: empezamos el Tema 2");
                escritor.WriteLine("Martes: practicamos con System.IO");
                escritor.WriteLine("Miércoles: ya domino using");
            }

        
            using (StreamReader lector = new StreamReader(ruta))
            {
                string contenido = lector.ReadToEnd();
                Console.WriteLine($"Contenido de {ruta}:");
                Console.Write(contenido);
            }

            
        }
    }
}
        
    

