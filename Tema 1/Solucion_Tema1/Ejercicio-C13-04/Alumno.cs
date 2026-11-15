using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C13_04
{
    internal class Alumno
    {
        private string nombre;
        private double nota;

        public Alumno(string nombre, double nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }

        public string Nombre { get; set; }
        public double Nota{get; set;}

    }
}

