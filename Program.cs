using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiEjercicio1
{

    class Program
    {
        static int Salir = 0;
        ArrayList ArrayVideojuegos = new ArrayList();

        public int Menu()
        {
            int seleccion;
            Console.Write("=============\n" +
                "    MENU    =\n" +
                "=============\n\n" +
                "1) Insertar Nuevo Videojuego: \n" +
                "2) Eliminar Videojuego\n" +
                "3) Buscar Juego en la coleccion\n" +
                "4) Visualizar toda la lista de videojuegos\n" +
                "5) Visualizar un videojuego por año y estilo determinado\n" +
                "6) Modificar un videojuego\n" +
                "7) Borrar toda la lista\n" +
                "8) Salir\n\n" +
                "Elige una opcion: ");
            seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }

        public void Selection(int num)
        {
            string titulo, fabricantes;
            int seleccion, año,Estilo;
            seleccion = num;
            switch (seleccion)
            {
                case 1:
                    Console.Write("============================\n" +
                        "      Añadir Videojuego    =" +
                        "   \n============================\n" +
                        "a) Titulo: ");
                    titulo = Console.ReadLine();
                    Console.Write("b) Fabricante: ");
                    fabricantes = Console.ReadLine();
                    Console.Write("c) año: ");
                    año = Convert.ToInt32(Console.ReadLine());
                    Console.Write("D) Categoria: ");
                    Estilo = Convert.ToInt32(Console.ReadLine());
                    ArrayVideojuegos.Add(new Videojuegos(titulo, fabricantes, año, Estilo));
                    break;
                case 2:
                    Console.WriteLine("¿Que Videojuego desea eliminar? (Elija numero de 0 - " + (ArrayVideojuegos.Count-1+")"));
                    ArrayVideojuegos.RemoveAt(seleccion);
                    break;
                case 3:
                    string nombre;
                    Console.WriteLine("Elige un Videojuego para comprobar su" +
                        " existencia y mirar sus datos (Elige un Videojuego de 0 - "+ (ArrayVideojuegos.Count-1)+")\n" +
                        "Dime el nombre del Videojuego:");
                    nombre = Console.ReadLine();
                    foreach (Videojuegos v in ArrayVideojuegos)
                    {
                        if (nombre == v.Titulo)
                        {
                            Console.Write("El Videojuego ya Existe \nNombre: "+v.Titulo+"\nFabricante: "+v.Fabricante+"\nAño: "+v.Año+"\nCategoria: "+v.Est+"\n");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Visualizar todos los videojuegos");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
                case 8:

                    Console.WriteLine("Estas saliendo del programa...");
                    Salir = 8;
                    break;
            }
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            while ( Salir != 8)
            {
                p1.Selection(p1.Menu());
            }
            Console.ReadKey();
        }
    }
}
