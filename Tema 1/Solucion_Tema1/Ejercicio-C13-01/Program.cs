using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C13_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 12, 7, 25, 3, 18, 40, 9, 16 };

            List<int> pares = numeros.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Números pares:");
            foreach (int n in pares)
            {
                Console.WriteLine(n);
            }

            List<int>mayoresque10=numeros.Where(n2=> n2 > 10).ToList();
            Console.WriteLine("Números mayores que 10:");
            foreach (int n2 in mayoresque10)
            {
                Console.WriteLine(n2);
            }

            List<int> entre10y20 = numeros.Where(n3 => n3 > 10 && n3 < 20).ToList();
            Console.WriteLine("Números entre 10 y 20:");
            foreach (int n3 in entre10y20)
            {
                Console.WriteLine(n3);
            }

            int impares = numeros.Count(n4 => n4 %2!=0);
            Console.WriteLine("Números impares:" + impares);
        }
    }
}
