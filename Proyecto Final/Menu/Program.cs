namespace Menuprincipal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Mopcion = 0;

           
                Console.WriteLine("---------------------");
                Console.WriteLine("Menú principal");
                Console.WriteLine("1.- Listas");
                Console.WriteLine("2.- Pilas");
                Console.WriteLine("3.- Colas");
                Console.WriteLine("4.- Árbol");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("---------------------");
                Console.WriteLine("Seleccione una opcion =>");
                Mopcion = Convert.ToInt32(Console.ReadLine());
            while (Mopcion <= 5)
            {

                switch (Mopcion)
                {
                    case 1:
                        Console.Clear();
                        Menuprincipal.Listas.Menulista.Mlista(new string[0]);
                        break;



                    case 2:
                        Console.Clear();
                        Menuprincipal.Pilas.Menupila.Mpila(new string[0]);
                        break;



                    case 3:
                        Console.Clear();
                        Menuprincipal.Colas.Menucola.Mcola(new string[0]);
                        break;



                    case 4:
                        Console.Clear();
                        Menuprincipal.Arbol.Menuarbol.Marbol(new string[0]);
                        break;



                    case 5:
                        Console.WriteLine();
                        
                        break;



                    default:
                        Console.WriteLine("Selecciones otra opción");
                        break;
                }
                break;
            }
        }
    }
}
