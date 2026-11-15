using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productos = new Dictionary<string, decimal>();

            productos.Add("Producto 1", 10.5m);
            productos.Add("Producto 2", 20.0m);
            productos.Add("Producto 3", 15.75m);
            productos.Add("Producto 4", 25.0m);
            productos.Add("Producto 5", 40.0m);


            Console.WriteLine("Ingrese el nombre del producto: ");
            String nombreProducto = Console.ReadLine();

            if (nombreProducto != null && productos.ContainsKey(nombreProducto))
            {
                productos.TryGetValue(nombreProducto, out decimal precioProducto);
                Console.WriteLine("El precio del producto " + nombreProducto + " es: " + precioProducto);
            }
            else
            {
                Console.WriteLine("El producto no existe en el diccionario.");
            }


            productos["Producto1"] = 11.0m;

            Console.Write("El producto 'Producto1' ha sido agregado al diccionario con un precio de 11.0.");

            Console.WriteLine();

            decimal sumaMedia = 0;
            foreach (KeyValuePair<string, decimal> producto in productos)
            {
                sumaMedia += producto.Value;
            }
            decimal precioMedio = sumaMedia / productos.Count;
            Console.Write("El precio medio de todos los productos es: " + precioMedio);
        }
    }
    }

        

