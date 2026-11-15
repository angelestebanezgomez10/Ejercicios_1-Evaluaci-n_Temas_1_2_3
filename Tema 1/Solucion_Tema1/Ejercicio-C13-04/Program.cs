using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C13_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(new Alumno("Ana", 8.5));
            alumnos.Add(new Alumno("Luis", 4));
            alumnos.Add(new Alumno("Marta", 6.5));
            alumnos.Add(new Alumno("Pablo", 3.5));
            alumnos.Add(new Alumno("Lucía", 9));
            alumnos.Add(new Alumno("Jorge", 5));
            alumnos.Add(new Alumno("Sara", 7));


            List<Alumno> alumnosAprobados = alumnos.Where(a => a.Nota >= 5).ToList();
            foreach (Alumno alumno in alumnosAprobados)
            {
                Console.WriteLine("Aprobados: " + alumnosAprobados.Count + " de " + alumnos.Count);
            }
            
            
        }
    }
}
