namespace Menuprincipal.Arbol
{
    internal class Menuarbol
    {
         public static void Marbol(string[] args)
        {
            arbol miArbol = new arbol();

            int Aopcion = 0;


            
                Console.WriteLine("----------------------------");
                Console.WriteLine("Menú Arbol");
                Console.WriteLine("1.- Insertar nodo");
                Console.WriteLine("2.- Tamaño");
                Console.WriteLine("3.- Altura");
                Console.WriteLine("4.- LRP");
                Console.WriteLine("5.- Recorrido");
                Console.WriteLine("6.- Regresar al menu principal");
                Console.WriteLine("----------------------------");
                Aopcion = Convert.ToInt32(Console.ReadLine());
            while (Aopcion <= 6)
            {
                switch (Aopcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese valor al albol");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        miArbol.insertar(valor);
                        break;



                    case 2:
                        Console.WriteLine($"El tamaño del arbol es {miArbol.Tamaño(miArbol.raiz)}");
                        break;



                    case 3:
                        Console.WriteLine($"El altura del arbol es {miArbol.Altura(miArbol.raiz)}");
                        break;



                    case 4:
                        miArbol.LRP();
                        break;



                    case 5:
                        miArbol.Recorrido(miArbol.raiz);
                        break;



                    case 6:
                        Console.Clear();
                        Menuprincipal.Program.Main(new string[4]);
                        break;



                    default:
                        Console.WriteLine("Opció Incorrecta, selecciona otra");
                        break;
                }
                break;
            }
        }
    }
}