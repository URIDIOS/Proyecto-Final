using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menuprincipal.Listas
{
    public class nodo
    {
        public int Valor;
        public nodo Next;

        public nodo(int valor)
        {
            Valor = valor;
            Next = null;
        }
    }
}
