using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Menuprincipal.Pilas.Menupila;

namespace Menuprincipal.Pilas
{
    public class pila
    {
        internal class Pila
        {
            private int Max;
            private int tope = 0;
            private nodo inicio;
            public Pila(int max)
            {
                Max = max;
                inicio = null;
            }

            private bool empty()
            {
                if (inicio == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            private bool full()
            {
                if (Max == tope)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

            public void print()
            {
                if (empty())
                {
                    Console.WriteLine("La pila esta vacia");
                    return;
                }
                nodo act = inicio;
                Console.WriteLine("Este es el contenido de la pila");
                while (act != null)
                {
                    Console.WriteLine($"[{act.Valor}]");
                    act = act.Sig;
                }

            }

            public bool push(int valor)
            {
                if (!full())
                {
                    nodo NodoNuevo = new nodo(valor);
                    NodoNuevo.Sig = inicio;
                    inicio = NodoNuevo;
                    tope++;
                    Console.WriteLine($"El valor {valor} fue insertado exitosamente");
                    return true;
                }
                else
                {
                    Console.WriteLine("La pila esta llena, no se puede insertar mas we");
                    return false;
                }
            }

            public int pop()
            {
                if (!empty())
                {
                    int valor = inicio.Valor;
                    inicio = inicio.Sig;
                    tope--;
                    Console.WriteLine($"El valor {valor} fue eliminado");
                    return valor;
                }
                else
                {
                    Console.WriteLine("No hay nada que eliminar");
                    return -1;
                }
            }
        }
    }
}
