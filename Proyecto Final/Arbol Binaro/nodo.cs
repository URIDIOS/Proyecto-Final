using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    internal class nodo
    {
        public int valor;
        public nodo izq;
        public nodo der;

        public nodo(int Valor)
        {
            valor = Valor;
            izq = null;
            der = null;
        }
    }
}
