using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            if(!int.TryParse(Console.ReadLine(),out int anio) || anio < 1)
            {
                Console.WriteLine("El año debe ser un número entero mayor que 0.");
                return;
            }

            Console.Write("Ingrese un mes (1-12): ");
            if (!int.TryParse(Console.ReadLine(), out int mes) || mes < 1 || mes>12)
            {
                Console.WriteLine("El mes debe estar entre 1 y 12");
                return;
            }

            Console.Write("Día: ");
            if (!int.TryParse(Console.ReadLine(), out int dia))
            {
                Console.WriteLine("El día debe ser un número entero.");
                return;
            }

            if(anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
            {
                Console.WriteLine($"{anio} es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"{anio} no es un año bisiesto.");
            }

            string opcion = mes switch
            {
                1 => "enero",
                2 => "febrero",
                3 => "marzo",
                4 => "abril",
                5 => "mayo",
                6 => "junio",
                7 => "julio",
                8 => "agosto",
                9 => "septiembre",
                10 => "octubre",
                11 => "noviembre",
                12 => "diciembre",
                _ => "desconocido"
            };
            int diaMes = mes switch {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => esBisiesto ? 29 : 28,
                _ => 0
            };

            string estacion = mes switch
            {
                12 or 1 or 2 => "invierno",
                3 or 4 or 5 => "primavera",
                6 or 7 or 8 => "verano",
                _ => "otoño"
            };

           
            Console.WriteLine();
            Console.WriteLine("El año" + anio + "es bisiesto");
            Console.WriteLine($"El mes de {opcion} de {anio} tiene {diaMes} días.");

            if (dia < 1 || dia > diaMes)
            {
                Console.WriteLine($"La fecha {dia}/{mes}/{anio} NO es válida: {opcion} solo tiene {diaMes} días.");
            }
            else
            {
                Console.WriteLine($"La fecha {dia} de {opcion} de {anio} es válida.");
                Console.WriteLine($"Quedan {diaMes - dia} días para acabar el mes.");
                Console.WriteLine($"Estación aproximada (por meses completos): {estacion}.");
            }
        }
    }
}
