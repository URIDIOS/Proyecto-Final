namespace Arbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arbol a = new arbol();
            a.insertar(15);
            a.insertar(8);
            a.insertar(23);
            a.insertar(5);
            a.insertar(12);
            a.insertar(25);
            a.insertar(6);
            a.insertar(17);
            a.Recorrido(a.raiz);
            Console.ReadLine();
        }
    }
}