using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("tomate");
            lista.Add("patata");
            lista.Add("manzana");
            lista.Add("espinaca");
            lista.Add("sandía");

            int numero = 1;
            foreach (string item in lista)
            {
                
                Console.WriteLine(numero + ": " + item);
                numero++;
            }

            lista.Remove("tomate");
            Console.Write("Se ha eliminado el elemento tomate de la lista");

            Console.WriteLine("");
            if (lista.Contains("tomate"))
            {
                Console.WriteLine("El elemento tomate está en la lista");
            }
            else
            {
                Console.WriteLine("El elemento tomate no está en la lista");
            }

            Console.WriteLine("Quedan " + lista.Count + " elementos en la lista");

        }
    }
}
