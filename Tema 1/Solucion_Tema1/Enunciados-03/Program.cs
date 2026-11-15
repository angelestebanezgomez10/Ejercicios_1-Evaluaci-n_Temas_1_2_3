using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            String numero = Console.ReadLine();

            if (!int.TryParse(numero, out int numeroInt))
            {
                Console.WriteLine("Número no válido");
                return;
            }

            for (int i = 0; i <= 9; i++)
            {
                int resultado = numeroInt * (i + 1);

                Console.WriteLine(resultado);
            }

            int suma = 0;

            int contador = 0;

            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    suma += contador;
                }
                contador++;
            }

            Console.WriteLine("La suma de los números pares entre 0 y 100 es: " + suma);

            int opcion;

            do
            {
                Console.WriteLine("Ingrese una opción (1, 2, 3) o 0 para salir: ");
                String opcionString = Console.ReadLine();
                if (!int.TryParse(opcionString, out opcion))
                {
                    Console.WriteLine("Opción no válida");
                    opcion = -1;
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Opción 1 seleccionada");
                        break;
                    case 2:
                        Console.WriteLine("Opción 2 seleccionada");
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            while (opcion != 3);

        }
    }
}