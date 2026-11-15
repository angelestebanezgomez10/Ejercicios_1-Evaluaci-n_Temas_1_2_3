using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Tema_3.Datos;
using Tema_3.Modelo;

namespace Tema_3.Repositorios
{
    internal class ProductoRepositorio : IProductoRepositorio
    {
        // Las columnas que leen todos los SELECT, en un único sitio
        private const string Columnas = "Id, Nombre, Precio, Stock, Activo";

        // Convierte la fila ACTUAL del lector en un objeto Producto
        private static Producto MapearProducto(SqlDataReader lector)
        {
            int colPrecio = lector.GetOrdinal("Precio");
            int colStock = lector.GetOrdinal("Stock");

            return new Producto
            {
                Id = lector.GetInt32(lector.GetOrdinal("Id")),
                Nombre = lector.GetString(lector.GetOrdinal("Nombre")),
                Precio = lector.GetDecimal(colPrecio),
                Stock = lector.GetInt32(colStock),
                Activo = lector.GetBoolean(lector.GetOrdinal("Activo"))
   
            };
        }

        public Producto? ObtenerPorId(int id)
        {
            using SqlConnection conexion = Conexion.Conectar();
            using SqlCommand comando = new SqlCommand(
                $"SELECT {Columnas} FROM Productos WHERE Id = @id", conexion);
            comando.Parameters.AddWithValue("@id", id);
            using SqlDataReader lector = comando.ExecuteReader();

            // Por clave primaria hay como mucho UNA fila → if, no while
            return lector.Read() ? MapearProducto(lector) : null;
        }

        public List<Producto> ObtenerTodas()
        {
            List<Producto> resultado = new();
            using SqlConnection conexion = Conexion.Conectar();
            using SqlCommand comando = new SqlCommand(
                $"SELECT {Columnas} FROM Productos WHERE Activo = 1 ORDER BY Nombre", conexion);
            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
                resultado.Add(MapearProducto(lector));

            return resultado;
        }

        public List<Producto> BuscarPorNombre(string texto)
        {
            List<Producto> resultado = new();
            using SqlConnection conexion = Conexion.Conectar();
            using SqlCommand comando = new SqlCommand(
                $"SELECT {Columnas} FROM Productos " +
                "WHERE Activo = 1 AND Nombre LIKE @patron ORDER BY Nombre", conexion);
            comando.Parameters.AddWithValue("@patron", $"%{texto}%");   // §3.5.6, ejemplo 3
            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
                resultado.Add(MapearProducto(lector));

            return resultado;
        }

        public int Insertar(Producto p)
        {
            string sql = @"INSERT INTO Productos (Nombre, Precio, Stock)
                   OUTPUT INSERTED.Id
                   VALUES (@nombre, @precio, @stock)";
            try
            {
                using SqlConnection conexion = Conexion.Conectar();
                using SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", p.Nombre);
                comando.Parameters.AddWithValue("@precio", p.Precio);
                comando.Parameters.AddWithValue("@stock", p.Stock);

                p.Id = (int)comando.ExecuteScalar()!;   // el objeto ya conoce su Id
                return p.Id;
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                throw new InvalidOperationException($"Ya existe un producto con el nombre {p.Nombre}", ex);
            }
        }

        public bool Actualizar(Producto p)
        {
            try
            {
                using SqlConnection conexion = Conexion.Conectar();
                using SqlCommand comando = new SqlCommand(
                    @"UPDATE Productos
              SET Nombre = @nombre, Precio = @precio, Stock = @stock
              WHERE Id = @id", conexion);
                comando.Parameters.AddWithValue("@nombre", p.Nombre);
                comando.Parameters.AddWithValue("@precio", p.Precio);
                comando.Parameters.AddWithValue("@stock", p.Stock);
                comando.Parameters.AddWithValue("@id", p.Id);

                return comando.ExecuteNonQuery() == 1;   // false → no existe ese Id
            }
            catch (SqlException ex) when (ex.Number == 560 || ex.Number == 2627)
            {
                throw new InvalidOperationException($"Ya existe otro producto con el nombre {p.Nombre}", ex);
            }
        }

        // Borrado LÓGICO: la fila se queda, marcada como baja (§3.4.5)
        public bool DarDeBaja(int id)
        {
            using SqlConnection conexion = Conexion.Conectar();
            using SqlCommand comando = new SqlCommand(
                "UPDATE Productos SET Activo = 0 WHERE Id = @id AND Activo = 1", conexion);
            comando.Parameters.AddWithValue("@id", id);

            return comando.ExecuteNonQuery() == 1;   // false → no existe o ya estaba de baja
        }

        // Borrado FÍSICO: la fila desaparece para siempre
        public bool Eliminar(int id)
        {
            try
            {
                using SqlConnection conexion = Conexion.Conectar();
                using SqlCommand comando = new SqlCommand(
                    "DELETE FROM Productos WHERE Id = @id", conexion);
                comando.Parameters.AddWithValue("@id", id);

                return comando.ExecuteNonQuery() == 1;
            }
            catch (SqlException ex) when (ex.Number == 547)   // otra tabla la referencia (clave ajena)
            {
                throw new InvalidOperationException(
                    $"El producto {id} tiene datos relacionados: usa mejor el borrado lógico", ex);
            }
        }

    }
}
