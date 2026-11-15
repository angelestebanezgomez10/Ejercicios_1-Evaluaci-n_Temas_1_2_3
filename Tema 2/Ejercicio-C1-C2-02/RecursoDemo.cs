using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C1_C2_02
{
    internal class RecursoDemo : IDisposable
    {
        private string nombre;

        public RecursoDemo(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine(nombre + "abierto");
        }

        public void Dispose()
        {
            Console.WriteLine(nombre + "cerrado");
        }

        public void Usar()
        {
            Console.WriteLine(nombre + "usado");
        }
    }
}
