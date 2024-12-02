using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuprincipal.Listas
{
    public class Menulista
    {
        public static void Mlista(string[] args)
        {
            lista lista = new lista();
            int Lopcion;
            do
            {
                Console.WriteLine("MENU LISTAS\r\n---------------------------------\r\n1.- Insertar Nodo\r\n2.- Imprimir Tamaño\r\n3.- Buscar Nodo\r\n4.- Borrar Nodo\r\n5.- Modificar Nodo\r\n6.- Buscar Valor\r\n7.- Imprimir Lista\r\n8.- Regresar al menú principal\r\n_____________________\r\nSelecciónar Opción => ");
                Lopcion = int.Parse(Console.ReadLine());
                switch (Lopcion)
                {
                    case 1:
                        Console.WriteLine("Deme el valor del nodo= ");
                        int valor = int.Parse(Console.ReadLine());
                        lista.add(valor);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("La lista tiene: " + lista.count() + " nodo/nodos");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Deme la posicion del nodo= ");
                        int buscadorpos = int.Parse(Console.ReadLine());
                        nodo nodoencont = lista.find(buscadorpos);
                        if (nodoencont != null)
                        {
                            Console.WriteLine("El nodo que busco tiene el valor " + nodoencont.Valor);
                        }
                        else
                        {
                            Console.WriteLine("No hay ningun nodo en esa posicion");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Deme la posicion del nodo que quiera borrar borrar= ");
                        int posicionbor = Convert.ToInt32(Console.ReadLine());
                        lista.delete(posicionbor);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Deme la posicion del nodo que vamos a modificar: ");
                        int valorant = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deme el nuevo valor para el nodo por favor: ");
                        int valornew = Convert.ToInt32(Console.ReadLine());
                        lista.change(valorant, valornew);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Deme la posicion del nodo para buscar el valor: ");
                        int valorencont = Convert.ToInt32(Console.ReadLine());
                        nodo nodovalor = lista.findvalue(valorencont);
                        if (nodovalor != null)
                        {
                            Console.WriteLine("Ese nodo tiene como valor el: " + nodovalor.Valor);
                        }
                        else
                        {
                            Console.WriteLine("El valor no fue encontrado");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        lista.Print();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Regresando al menú principal...");
                        //Console.ReadLine();
                        Console.Clear();
                        Menuprincipal.Program.Main(new string[1]);
                        break;
                    default:
                        Console.WriteLine("Perdone pero esa opción no es valida, intentolo de nuevo");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (Lopcion != 8);
        }
    }
}
