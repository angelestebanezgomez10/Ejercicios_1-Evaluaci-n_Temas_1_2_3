using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo coche = new Coche("Toyota", "Corolla", 2020, 4);
            Vehiculo moto = new Moto("Honda", "CBR", 2019, 600);

            coche.MostrarInfo();
            Console.WriteLine();
            moto.MostrarInfo();
        }
    }
}
