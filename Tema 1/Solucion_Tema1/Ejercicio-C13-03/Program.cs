using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("Teclado", "Periféricos", 25.99));
            productos.Add(new Producto("Monitor", "Pantallas", 149.00));
            productos.Add(new Producto("Ratón", "Periféricos", 12.50));
            productos.Add(new Producto("Portátil", "Ordenadores", 799.00));
            productos.Add(new Producto("Webcam", "Periféricos", 39.90));
            productos.Add(new Producto("Tablet", "Ordenadores", 229.00));



            List<Producto> deMenorAmayor= productos.OrderBy(p => p.Precio).ToList();
            Console.WriteLine("\nProductos ordenados por precio de menor a mayor: ");
            foreach (Producto p in deMenorAmayor)
            {
                Console.WriteLine($"{p.Nombre} - {p.Precio:F2} $");
            }

            Producto ProductoMasCaro = productos.OrderByDescending(p => p.Precio).First();
            Console.WriteLine("\nProducto más caro: ");
            Console.WriteLine($"{ProductoMasCaro.Nombre} - {ProductoMasCaro.Precio:F2} $");

            List<Producto> CategoriaYnombre = productos.OrderBy(p => p.Categoria).ThenBy(p => p.Nombre).ToList();
            Console.WriteLine("\nProductos ordenados por categoría y nombre: ");
            foreach(Producto p in CategoriaYnombre)
            {
                Console.WriteLine($"{p.Categoria} - {p.Nombre}");
            }

            Producto impresoras=productos.FirstOrDefault(p => p.Categoria == "Impresoras");
            if(impresoras != null)
            {
                Console.WriteLine($"\nProducto de la categoría 'Impresoras': {impresoras.Nombre} $");
            }
            else
            {
                Console.WriteLine("\nNo se encontraron productos de la categoría 'Impresoras'.");
            }

        }
    }
}
