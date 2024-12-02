using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Menuprincipal.Pilas.pila;

namespace Menuprincipal.Pilas
{
    public class Menupila
    {
        public static void Mpila(string[] args)
        {
            Pila pila = null;
            int Popcion = 0;
            int tamaño = 0;

            while (Popcion != 5)
            {
                Console.WriteLine("\nMENU Pilas");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Establecer Tamaño");
                Console.WriteLine("2.- Push");
                Console.WriteLine("3.- Pop");
                Console.WriteLine("4.- Imprimir");
                Console.WriteLine("5.- Regresar al menú principal");
                Console.WriteLine("_____________________");
                Console.Write("Seleccionar Opción => ");
                Popcion = Convert.ToInt32(Console.ReadLine());

                switch (Popcion)
                {
                    case 1:
                        Console.Write("Ingrese el tamaño para la pila: ");
                        tamaño = Convert.ToInt32(Console.ReadLine());
                        pila = new Pila(tamaño);
                        Console.WriteLine("El tamaño de la pila fue ingresado");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        if (pila == null)
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la pila.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("Ingrese el valor que quiera añadir: ");
                            int valor = Convert.ToInt32(Console.ReadLine());
                            pila.push(valor);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        if (pila == null)
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la pila.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            pila.pop();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        if (pila == null)
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la pila.");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else
                        {
                            pila.print();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        /*
                         Console.WriteLine("Regresando al menú principal...");
                        Console.ReadLine();
                         */
                        Console.Clear();
                        Menuprincipal.Program.Main(new string[2]);
                        break;
                        
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
