using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C8_C9_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Tareas = new List<string>();

            Tareas.Add("Deporte");
            Tareas.Add("Caminar");
            Tareas.Add("Hacer la compra");
            int contador = 0;

            foreach(string tarea in Tareas) {
                contador++;
                Console.WriteLine(contador + " " + tarea);
            
            }

            Tareas.Remove("Deporte");
            Console.WriteLine("Se ha eliminado Deporte");

            Console.WriteLine("Te quedan " + Tareas.Count() + " tareas. ");


        }
    }
}
