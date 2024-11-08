using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idea_bibliotecarenovada
{
    internal class Program
    {
        static void Main(string[] args)
            {
                int contadorLibros = 0; 
                string opcion;

            do
            {
                Console.WriteLine("Biblioteca");
                Console.WriteLine("1. Agregar libros");
                Console.WriteLine("2. Contar libros disponibles");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la cantidad de libros a agregar: ");

                        if (int.TryParse(Console.ReadLine(), out int librosAAgregar))
                        {
                            if (librosAAgregar > 0) // Solo suma si es número positivo
                            {
                                contadorLibros += librosAAgregar;
                                Console.WriteLine("libro/s agregado/s");
                            }
                            else
                            {
                                Console.WriteLine("Por favor, ingrese un número positivo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Ingrese un número.");
                        }
                        break;

                    case "2":
                        ContarLibros(contadorLibros);
                        break;

                    case "3":
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine();

            } while (opcion != "3"); //si la opcion no es igual a 3, continua el bloque
            }

            static void ContarLibros(int contadorLibros)
            {
                Console.WriteLine("Total de libros disponibles: " + contadorLibros);
            }
        }

    }


