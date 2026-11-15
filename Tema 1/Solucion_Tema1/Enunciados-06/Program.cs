using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_06
{
    internal class Program

    {

        static int Sumar(params int[] numeros)
        {
            int total = 0;
            foreach (int numero in numeros)
            {
                total += numero;
            }
            return total;
        }

        static bool DividirSeguro(double dividendo, double divisor, out double resultado)
        {
            if (divisor == 0)
            {
                resultado = 0;
                return false;
            }
            else
            {
                resultado = dividendo / divisor;
                return true;
            }
        }

        static String Saludar(string nombre, string saludo = "Hola")
        {
            return saludo + " " + nombre;
        }
        static void Main(string[] args)
        {

            int total = Sumar(1, 2, 3, 4, 5);
            Console.Write("La suma de los números es: " + total);

            Console.WriteLine();

            if (DividirSeguro(10,2, out double resultado))
            {
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
            if (DividirSeguro(10, 0, out double resultado2))
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }

            String saludo= Saludar("Juan", "Hola");
            Console.WriteLine(saludo);

        }
    }
}
