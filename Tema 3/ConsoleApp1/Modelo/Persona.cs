using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Modelo
{
    internal class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Email { get; set; } = "";
        public int Edad { get; set; }
        public bool Activo { get; set; } = true;

        public override string ToString() =>
            $"[{Id}] {Nombre} <{Email}>, {Edad} años{(Activo ? "" : " (baja)")}";



    }
}
