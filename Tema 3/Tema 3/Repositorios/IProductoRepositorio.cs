using System;
using System.Collections.Generic;
using System.Text;
using Tema_3.Modelo;

namespace Tema_3.Repositorios
{
    internal interface IProductoRepositorio
    {
        int Insertar(Producto p);                      // devuelve el Id generado
        Producto? ObtenerPorId(int id);                // null si no existe
        List<Producto> ObtenerTodas();                 // solo las activas
        List<Producto> BuscarPorNombre(string texto);
        bool Actualizar(Producto p);                   // false si el Id no existe
        bool DarDeBaja(int id);                       // borrado lógico
        bool Eliminar(int id);
    }
}
