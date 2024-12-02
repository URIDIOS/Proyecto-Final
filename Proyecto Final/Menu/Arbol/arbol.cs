using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Menuprincipal.Arbol
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
        public int Tamaño(nodo nodo)
        {
            if (nodo == null) return 0;
            return 1 + Tamaño(nodo.izq) + Tamaño(nodo.der);
        }



        // Altura
        public int Altura(nodo nodo)
        {
            if (nodo == null) return 0;
            int alturaIzq = Altura(nodo.izq);
            int alturaDer = Altura(nodo.der);
            return 1 + Math.Max(alturaIzq, alturaDer);
        }



        public void LRP()
        {
            int sumatoria = 0;
            int tamaño = Tamaño(raiz);
            CalcularSumatoria(raiz, 1, ref sumatoria); // La raíz empieza con profundidad 1

            if (tamaño == 0)
            {
                Console.WriteLine("El árbol está vacío, LRP no es aplicable.");
                return;
            }

            double lrp = (double)sumatoria / tamaño;
            Console.WriteLine($"El LRP del árbol es: {lrp:F2}");
        }

        private void CalcularSumatoria(nodo nodo, int profundidad, ref int sumatoria)
        {
            if (nodo != null)
            {
                sumatoria += profundidad; // Acumula la profundidad del nodo actual
                CalcularSumatoria(nodo.izq, profundidad + 1, ref sumatoria); // Recorre subárbol izquierdo
                CalcularSumatoria(nodo.der, profundidad + 1, ref sumatoria); // Recorre subárbol derecho
            }
        }


    }

    
}
