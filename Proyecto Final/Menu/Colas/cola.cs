using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuprincipal.Colas
{
    internal class cola
    {
        private int Max;
        private int count = 0;
        private nodo inicio;

        public cola(int max)
        {
            Max = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
            {
                return true;
            }
            return false;

        }

        private bool overflow()
        {
            if (Max == count)
            {
                return true;
            }
            return false;
        }

        public bool Insert(int num)
        {
            if (overflow())
            {
                return false;
            }

            nodo nuevoNodo = new nodo(num);
            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                nodo act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevoNodo;
            }
            count++;
            return true;
        }

        public int Extract()
        {
            if (underflow())
            {
                return -1;
            }

            int valorExtraido = inicio.Valor;
            inicio = inicio.Sig;
            count--;
            return valorExtraido;
        }

        public int Count()
        {
            return count;
        }

        public void Print()
        {
            if (underflow())
            {
                Console.WriteLine("Cola vacía.");
                return;
            }

            nodo act = inicio;
            Console.Write("Elementos en la cola: ");
            while (act != null)
            {
                Console.Write("-" + act.Valor + "-");
                act = act.Sig;
            }
            Console.WriteLine();
        }
    }
}
