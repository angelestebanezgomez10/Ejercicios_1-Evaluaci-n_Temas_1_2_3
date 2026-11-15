using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C10_01
{
    internal class Vehiculo
    {
        private String marca;
        private String modelo;
        private int anio;

        public Vehiculo(String marca, String modelo, int anio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Año: " + this.anio);
        }

         public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
    }        
    
}
