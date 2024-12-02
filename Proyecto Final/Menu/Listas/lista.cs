using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuprincipal.Listas
{
    internal class lista
    {
        private nodo inicio;

        public void add(int valor)
        {
            nodo nuevo = new nodo(valor);

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nodo actu = inicio;
                while (actu.Next != null)
                {
                    actu = actu.Next;
                }
                actu.Next = nuevo;
            }
            Console.WriteLine("Nodo insertado");

        }

        public int count()
        {
            int cont = 0;
            nodo actu = inicio;
            while (actu != null)
            {
                cont++;
                actu = actu.Next;
            }
            return cont;
        }

        public nodo find(int posicion)
        {
            nodo actu = inicio;
            int cont = 0;
            while (actu != null)
            {
                if (cont == posicion)
                    return actu;
                cont++;
                actu = actu.Next;

            }
            return null;
        }

        public void delete(int posicion)
        {
            if (inicio == null) return;
            if (posicion == 0)
            {
                inicio = inicio.Next;
                Console.WriteLine("Bueno el inicio de la lista se fue");
                return;
            }

            nodo actu = inicio;
            int cont = 0;
            while (actu.Next != null)
            {
                if (cont + 1 == posicion)
                {
                    actu.Next = actu.Next.Next;
                    Console.WriteLine($"Nodo en la posicion {posicion} fue eliminado");
                    return;
                }
                cont++;
                actu = actu.Next;
            }
            Console.WriteLine("La posicion que puso esta fuera de mi rango");
        }

        public void change(int posicion, int valornew)
        {
            nodo Nodo = find(posicion);
            if (Nodo != null)
            {
                Nodo.Valor = valornew;
                Console.WriteLine($"El valor del nodo a cambiado a {valornew}");
            }
            else
            {
                Console.WriteLine("No se pudo modificar");
            }
        }

        public nodo findvalue(int posicion)
        {
            nodo actu = inicio;
            int conta = 0;
            while (actu != null)
            {
                if (conta == posicion)
                    return actu;
                conta++;
                actu = actu.Next;
            }
            return null;
        }

        public void Print()
        {
            nodo actu = inicio;
            while (actu != null)
            {
                Console.Write("[" + actu.Valor + "]");
                actu = actu.Next;
            }
        }
    }
}
