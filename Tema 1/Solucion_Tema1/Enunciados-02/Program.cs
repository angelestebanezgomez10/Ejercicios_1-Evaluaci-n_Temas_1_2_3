using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese una nota del 0 al 10: ");
            String nota = Console.ReadLine();

            if (!decimal.TryParse(nota, out decimal notaDecimal))
            {
                Console.WriteLine("Nota no válida");
                return;
            }

            if (notaDecimal < 5)
            {
                Console.WriteLine("Insuficiente");

            }
            else if (notaDecimal >= 5 && notaDecimal < 6)
            {
                Console.WriteLine("Suficiente");
            }
            else if (notaDecimal >= 6 && notaDecimal < 7)
            {
                Console.WriteLine("Bien");
            }
            else if (notaDecimal >= 7 && notaDecimal < 9)
            {
                Console.WriteLine("Notable");
            }
            else if (notaDecimal >= 9 && notaDecimal <= 10)
            {
                Console.WriteLine("Sobresaliente");
            }


            switch (nota)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("Insuficiente");
                    break;
                case "5":
                    Console.WriteLine("Suficiente");
                    break;
                case "6":
                    Console.WriteLine("Bien");
                    break;
                case "7":
                case "8":
                    Console.WriteLine("Notable");
                    break;
                case "9":
                case "10":
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("Nota no válida");
                    break;

            }
        } 
    }
}
