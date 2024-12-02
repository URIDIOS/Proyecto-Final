using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuprincipal.Colas
{
    public class Menucola
    {
        public static void Mcola(string[] args)
        {
            cola cola = null;
            int tamaño = 0;

            
                Console.WriteLine("MENU Colas");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Establecer Tamaño");
                Console.WriteLine("2.- Imprimir conteo");
                Console.WriteLine("3.- Insert");
                Console.WriteLine("4.- Extract");
                Console.WriteLine("5.- Imprimir Cola");
                Console.WriteLine("6.- Regresar al menu principal");
                Console.WriteLine("_____________________");
                Console.Write("Seleccionar Opción => ");

                int copcion = Convert.ToInt32(Console.ReadLine());
            while (copcion <= 6)
            {
                switch (copcion)
                {
                    case 1:
                        Console.Write("Ingrese el tamaño de la cola: ");
                        tamaño = int.Parse(Console.ReadLine());
                        cola = new cola(tamaño);
                        Console.WriteLine("Tamaño de la cola establecido a " + tamaño);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        if (cola != null)
                        {
                            Console.WriteLine("Conteo de elementos en la cola: " + cola.Count());
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la cola.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        if (cola != null)
                        {
                            Console.Write("Ingrese el valor a insertar: ");
                            int valor = int.Parse(Console.ReadLine());
                            if (cola.Insert(valor))
                            {
                                Console.WriteLine("Valor insertado: " + valor);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("No se pudo insertar, cola llena.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la cola.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        if (cola != null)
                        {
                            int valorExtraido = cola.Extract();
                            if (valorExtraido != -1)
                            {
                                Console.WriteLine("Valor extraído: " + valorExtraido);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Cola vacía. No se puede extraer.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la cola.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 5:
                        if (cola != null)
                        {
                            cola.Print();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Primero debe establecer el tamaño de la cola.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case 6:
                        Console.WriteLine("Regresando al menú principal...");
                        //Console.ReadLine();
                        Console.Clear();
                        Menuprincipal.Program.Main(new string[3]);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                break;
            }
        }
    }
}
