using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_10
{
    internal record Alumno(string Nombre, int nota);
    
}
internal class Program
    {
        static void Main(string[] args)
        {

            List<Alumno> alumnos = new List<Alumno>
            {
            new Alumno("Juan", 0),
            new Alumno("María",  2),
            new Alumno("Pedro", 9),
            new Alumno("Ana", 10),
            new Alumno("Luis", 5),
            new Alumno("Lucía", 7),
            };
        
        List<int> alumnosAprobados = alumnos.Where(a => a.nota >= 5).OrderByDescending(a => a.nota).Select(a => a.nota).ToList();

        foreach(var alumno in alumnosAprobados)
        {
            Console.WriteLine($"Alumno aprobado: {alumno}");
        }
        decimal notaMedia = alumnosAprobados.Average();

    }
}
