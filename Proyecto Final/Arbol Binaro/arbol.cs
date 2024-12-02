using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arbol
{
    internal class arbol
    {
        public nodo raiz;
        private nodo obs;
        public void Recorrido(nodo q) 
        { 
          if(q != null) 
            {
                Console.Write($"{q.valor},");
                Recorrido(q.izq);
                Console.Write($"{q.valor},");
                Recorrido(q.der);
                Console.Write($"{q.valor},");
            }
        }

        private bool FindKey(int v)
        {
            bool Found = false;
            nodo q;
            q = raiz;
            while (!Found && q != null)
            {
                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.valor)
                    {
                        if (q.izq == null)
                            obs = q;
                        q = q.izq;

                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }

                }

            }
            return Found;
        }
        public void insertar(int v)
        {
            nodo nuevo, psave;
            bool found = false;
            psave = obs;
            found = FindKey(v);
            if (found) 
            {
                Console.WriteLine("El nodo ya existe");
                obs= psave;
            }
            else 
            {
                nuevo = new nodo(v);
                if(raiz == null) 
                { 
                 raiz = nuevo;
                 obs = nuevo;
                }
                else 
                { 
                 if(v < obs.valor)
                        obs.izq= nuevo;
                 else
                        obs.der = nuevo;
                 obs = nuevo;
                }
            }
        }


    }

    
}
