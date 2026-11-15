using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal Iva = 0.21m;
            int PrecioGratisEnvio = 50;
            decimal CosteEnvio = 4.95m;

            Console.WriteLine("Ingrese el nombre del producto: ");
            String nombreProducto = Console.ReadLine();
            if (nombreProducto == null || nombreProducto == "")
            {
                Console.WriteLine("Producto sin nombre");
            }
            Console.WriteLine("Ingrese el precio del producto: ");
            String resultadoProducto = Console.ReadLine();
            if (!decimal.TryParse(resultadoProducto, out decimal precioProducto))
            {

                if (precioProducto <= 0)
                {
                    Console.WriteLine("Precio no válido");
                    return;
                }
            }
            Console.WriteLine("Ingrese la cantidad de productos: ");
            String resultadoCantidad = Console.ReadLine();
            if (!int.TryParse(resultadoCantidad, out int cantidadProducto))
            {
                if (cantidadProducto <= 0)
                {
                    Console.WriteLine("Cantidad no válida");
                    return;
                }
            }
            Console.WriteLine("¿Tiene un cupón de descuento ? S/N");
            String tieneCupon = Console.ReadLine();
            if (tieneCupon?.ToUpper() == "S")
            {
               Console.WriteLine("Qué cupón tiene? (DAM10, DAM20)");
                String cupon = Console.ReadLine();
                cupon = cupon?.ToUpper();
                switch (cupon)
                {
                    case "DAM10":
                        precioProducto *= 0.1m;
                        break;
                    case "DAM20":
                        precioProducto *= 0.2m;
                        break;
                    default:
                        Console.WriteLine("Cupón no válido");
                        break;
                }
                decimal SubTotal = precioProducto * cantidadProducto;
                decimal descuento = SubTotal * (cupon == "DAM10" ? 0.1m : cupon == "DAM20" ? 0.2m : 0);
                decimal BaseImponible = SubTotal - descuento;

                decimal IvaTotal = BaseImponible * (decimal)Iva;

                Console.WriteLine("El subtotal es: " + SubTotal);
                Console.WriteLine("El descuento es: " + descuento);
                Console.WriteLine("La base imponible es: " + BaseImponible);
                Console.WriteLine("El IVA es: " + IvaTotal);

            }
            else if (tieneCupon?.ToUpper() == "N")
            {
                Console.WriteLine("No tiene cupón de descuento");
                decimal SubTotal = precioProducto * cantidadProducto;
                decimal BaseImponible = SubTotal;
                decimal IvaTotal = BaseImponible * (decimal)Iva;
                Console.WriteLine("El subtotal es: " + SubTotal);
                Console.WriteLine("La base imponible es: " + BaseImponible);
                Console.WriteLine("El IVA es: " + IvaTotal);
            }


        }
    }
}