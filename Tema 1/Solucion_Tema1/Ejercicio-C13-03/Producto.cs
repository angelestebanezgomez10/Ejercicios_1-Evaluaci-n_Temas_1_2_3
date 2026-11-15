using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C13_03
{
    internal class Producto
    {
        private string nombre;
        private string categoria;
        private double precio;

        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }


        public Producto(string nombre, string categoria, double precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }

    }
}
