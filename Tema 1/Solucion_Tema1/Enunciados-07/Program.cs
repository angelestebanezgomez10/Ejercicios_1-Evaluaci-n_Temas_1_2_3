using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro("El Quijote", "Miguel de Cervantes", 863));
            libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez", 417));
            libros.Add(new Libro("La sombra del viento", "Carlos Ruiz Zafón", 576));

            foreach (Libro libro in libros)
            {
                libro.MostrarInformacion();
                Console.WriteLine("Es largo: " + libro.EsLargo());
                Console.WriteLine();
            }
        }
    }
}
