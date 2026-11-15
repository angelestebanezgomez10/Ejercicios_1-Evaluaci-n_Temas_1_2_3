using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C1_C7_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldoInicial = 1000m;
            const decimal retiradaMaxima = 300m;
            int operacionesRealizadas = 0;

            string[] menu ={
                "1. Consultar saldo",
                "2. Ingresar dinero",
                "3. Retirar dinero",
                "4. Salir"
            };

            foreach (string opcion in menu)
            {
                Console.WriteLine(opcion);
            }

            do
            {
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {

                    case "1":
                        Console.WriteLine($"Su saldo actual es: {saldoInicial}€");
                        break;

                    case "2":
                        Console.WriteLine($"Ingrese la cantidad a ingresar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal ingreso) && ingreso > 0)
                        {
                            saldoInicial += ingreso;
                            Console.WriteLine($"Se han ingresado {ingreso}€. Su nuevo saldo es: {saldoInicial}€");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Ingrese la cantidad a retirar, máximo {retiradaMaxima}€ : ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal retirada) && retirada > 0)
                        {
                            if (retirada <= retiradaMaxima && retirada <= saldoInicial)
                            {
                                saldoInicial -= retirada;
                                Console.WriteLine($"Se han retirado {retirada}€. Su nuevo saldo es: {saldoInicial}€");
                            }
                            else
                            {
                                Console.WriteLine("Cantidad inválida o excede el límite de retirada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Vuelva pronto.");
                        Console.WriteLine($"Operaciones realizadas {operacionesRealizadas} y el saldo es de {saldoInicial}");
                        return;
                }
                operacionesRealizadas++;
            } while (true);


        }
    }
}
