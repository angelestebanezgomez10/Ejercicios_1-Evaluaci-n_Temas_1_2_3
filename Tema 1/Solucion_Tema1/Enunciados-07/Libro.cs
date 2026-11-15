using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_07
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private int paginas;

        public Libro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public bool EsLargo() => paginas > 300;

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo}, Autor: {autor}, Páginas: {paginas}");
        }

    }
 
}
