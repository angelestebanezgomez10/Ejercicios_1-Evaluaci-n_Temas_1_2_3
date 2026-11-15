using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_3.Modelo
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; } = true;
        public override string ToString() =>
        $"[{Id}] {Nombre} - {Precio:0.00} € - Stock: {Stock}{(Activo ? "" : " (baja)")}";
    }
}
