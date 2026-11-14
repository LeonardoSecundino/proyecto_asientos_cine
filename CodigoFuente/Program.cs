using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoFuente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Validas;
            bool[,] Asientos = new bool[10, 10];
            int Num;
            do
            {
                do
                {
                    Console.WriteLine("--- MENÚ ---");
                    Console.WriteLine("1. Mostrar Matriz");
                    Console.WriteLine("2. Reservar Asiento");
                    Console.WriteLine("3. Liberar Asiento");
                    Console.WriteLine("4. Consultar Disponibilidad");
                    Console.WriteLine("5. Contar Ocupados y Disponibles");
                    Console.WriteLine("6. Indicar Porcentaje de Ocupación");
                    Console.WriteLine("7. Salir");
                    Console.WriteLine("Seleccione una opción:");

                    Validas = !int.TryParse(Console.ReadLine(), out Num);


                    if (Validas)
                    {
                        Console.WriteLine("Opción inválida, introduzca un número del 1 al 7.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                } while (Validas);
                Validas = true;
                switch (Num)
                {
                    case 1:
                        Console.WriteLine("Esta opcion no esta disponible en esta version");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        ReservarAsiento(Asientos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        liberarAsiento(Asientos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Esta opcion no esta disponible en esta version");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Esta opcion no esta disponible en esta version");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Esta opcion no esta disponible en esta version");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Saliendo del sistema...");
                        Validas = false;
                        break;
                }
            }while (Validas);
        }
        #region módulo de captura.

        public static void ReservarAsiento(bool[,] Asientos)
        {
            int fila;
            int columna;
            bool Validas;
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Ingrese la fila del asiento:");
                        Validas = !int.TryParse(Console.ReadLine(), out fila);
                        if (Validas)
                        {
                            Console.WriteLine("Opción inválida, introduce un numero.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (Validas);

                    do
                    {
                        Console.WriteLine("Ingrese la columna del asiento:");
                        Validas = !int.TryParse(Console.ReadLine(), out columna);
                        if (Validas)
                        {
                            Console.WriteLine("Opción inválida, introduce un numero.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (Validas);

                    Validas = fila >= 0 && fila < Asientos.GetLength(0) && columna >= 0 && columna < Asientos.GetLength(1);
                    if (!Validas)
                    {
                        Console.WriteLine("Coordenadas inválidas. Intente de nuevo.");
                    }

                } while (!Validas);

                if (Asientos[fila, columna] == false)
                {
                    Asientos[fila, columna] = true;
                    Console.WriteLine("Asiento reservado con éxito.");
                }
                else
                {
                    Console.WriteLine("El asiento ya se encuentra ocupado.");
                    Validas = false;
                }
            } while (!Validas);
        }

        public static void liberarAsiento(bool[,] Asientos)
        {
            int fila;
            int columna;
            bool Validas;
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Ingrese la fila del asiento:");
                        Validas = !int.TryParse(Console.ReadLine(), out fila);
                        if (Validas)
                        {
                            Console.WriteLine("Opción inválida, introduce un numero.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (Validas);

                    do
                    {
                        Console.WriteLine("Ingrese la columna del asiento:");
                        Validas = !int.TryParse(Console.ReadLine(), out columna);
                        if (Validas)
                        {
                            Console.WriteLine("Opción inválida, introduce un numero.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (Validas);

                    Validas = fila >= 0 && fila < Asientos.GetLength(0) && columna >= 0 && columna < Asientos.GetLength(1);
                    if (!Validas)
                    {
                        Console.WriteLine("Coordenadas inválidas. Intente de nuevo.");
                    }

                } while (!Validas);

                if (Asientos[fila, columna] == true)
                {
                    Asientos[fila, columna] = false;
                    Console.WriteLine("Asiento liberado (cancelado) con éxito.");
                }
                else
                {
                    Console.WriteLine("El asiento ya está libre.");
                    Validas = false;
                }
            } while (!Validas);
        }
        #endregion
    }
}
