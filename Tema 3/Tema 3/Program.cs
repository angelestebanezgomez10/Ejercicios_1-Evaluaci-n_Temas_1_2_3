using Microsoft.Data.SqlClient;
using Tema_3.Datos;
using Tema_3.Modelo;
using System;
using Tema_3.Repositorios;
using System.Text;


namespace Tema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;   // para que salgan bien tildes y emojis

            // 1) Antes de nada, comprobamos que hay conexión con AccesoDatos
            try
            {
                using var prueba = Conexion.Conectar();
                Console.WriteLine($"✅ Conectado a {prueba.Database} en {prueba.DataSource}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"❌ {ex.Message}: {ex.InnerException?.Message}");
                Console.WriteLine("¿Has ejecutado Scripts/crear-bd.sql en SSMS?");
                return;
            }

            // 2) El programa solo conoce la INTERFAZ: no sabe si por debajo hay ADO.NET o un ORM
            IProductoRepositorio repo = new ProductoRepositorio();

            int opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine("===== CRUD PRODUCTOS =====");
                Console.WriteLine("1. Listar productos activos");
                Console.WriteLine("2. Buscar por Id");
                Console.WriteLine("3. Buscar por nombre");
                Console.WriteLine("4. Insertar producto");
                Console.WriteLine("5. Actualizar producto");
                Console.WriteLine("6. Dar de baja (borrado lógico)");
                Console.WriteLine("7. Eliminar (borrado físico)");
                Console.WriteLine("0. Salir");
                opcion = LeerEntero("Opción: ");
                Console.WriteLine();

                try
                {
                    switch (opcion)
                    {
                        case 1:
                            Mostrar(repo.ObtenerTodas());
                            break;
                        case 2:
                            Producto? encontrado = repo.ObtenerPorId(LeerEntero("Id: "));
                            Console.WriteLine(encontrado?.ToString() ?? "No existe ningún producto con ese Id.");
                            break;
                        case 3:
                            Mostrar(repo.BuscarPorNombre(LeerTexto("Texto a buscar: ")));
                            break;
                        case 4:
                            var nueva = new Producto
                            {
                                Nombre = LeerTexto("Nombre: "),
                                Precio = LeerDecimal("Precio: "),
                                Stock = LeerEntero("Stock: ")
                            };
                            Console.WriteLine($"✅ Insertada con Id {repo.Insertar(nueva)}");
                            break;
                        case 5:
                            Producto? p = repo.ObtenerPorId(LeerEntero("Id a actualizar: "));
                            if (p == null)
                            {
                                Console.WriteLine("No existe ningún producto con ese Id.");
                                break;
                            }
                            Console.WriteLine($"Actual: {p}  (Intro = dejar igual)");
                            string nombre = LeerTexto($"Nombre [{p.Nombre}]: ", permitirVacio: true);
                            string precio = LeerTexto($"Precio [{p.Precio}]: ", permitirVacio: true);
                            string stock = LeerTexto($"Stock [{p.Stock}]: ", permitirVacio: true);
                            if (nombre != "") p.Nombre = nombre;
                            if (decimal.TryParse(precio, out decimal nuevoPrecio)) p.Precio = nuevoPrecio;
                            if (int.TryParse(stock, out int nuevoStock)) p.Stock = nuevoStock;
                            Console.WriteLine(repo.Actualizar(p) ? "✅ Actualizada" : "No se ha podido actualizar.");
                            break;
                        case 6:
                            Console.WriteLine(repo.DarDeBaja(LeerEntero("Id: "))
                                ? "✅ Dada de baja" : "No existe o ya estaba de baja.");
                            break;
                        case 7:
                            int idBorrar = LeerEntero("Id: ");
                            if (LeerTexto("¿Seguro? Se borrará para siempre (s/n): ").ToLower() == "s")
                                Console.WriteLine(repo.Eliminar(idBorrar) ? "✅ Eliminada" : "No existe ese Id.");
                            break;
                        case 0:
                            Console.WriteLine("¡Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (InvalidOperationException ex)   // errores "traducidos" por el repositorio
                {
                    Console.WriteLine($"⚠️ {ex.Message}");
                }
            } while (opcion != 0);

            // ---------- Funciones auxiliares de consola ----------

            static void Mostrar(List<Producto> productos)
            {
                if (productos.Count == 0)
                {
                    Console.WriteLine("(no hay resultados)");
                    return;
                }
                foreach (Producto p in productos)
                    Console.WriteLine(p);
            }

            static int LeerEntero(string mensaje)
            {
                int valor;
                Console.Write(mensaje);
                while (!int.TryParse(Console.ReadLine(), out valor))
                    Console.Write("  Escribe un número entero: ");
                return valor;
            }

            static decimal LeerDecimal(string mensaje)
            {
                decimal valor;
                Console.Write(mensaje);
                while (!decimal.TryParse(Console.ReadLine(), out valor))
                    Console.Write("  Escribe un número (ej: 12,50): ");
                return valor;
            }

            static string LeerTexto(string mensaje, bool permitirVacio = false)
            {
                string texto;
                do
                {
                    Console.Write(mensaje);
                    texto = (Console.ReadLine() ?? "").Trim();
                } while (texto == "" && !permitirVacio);
                return texto;
            }
        }
    }
}
            
