using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C8_C9_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTemperaturas = { 18,20,34,2,49 };
            int contador=0;
            int resultado = 0;

            foreach (int temperatura in arrayTemperaturas)
            {
                Console.WriteLine($"Las temperatura: {temperatura}");
                contador++;
                resultado += temperatura;
            }
        
            int media= resultado/contador;
           
            Console.WriteLine($"La media de las temperaturas es: {media}");

        }

        }
    }
