
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
            int seleccion, año;
            eEstilo Estilo;
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
                    Estilo = Categoria();
                    ArrayVideojuegos.Add(new Videojuegos(titulo, fabricantes, año, Estilo));
                    Console.ReadKey();
                    break;
                case 2:
                    if ((ArrayVideojuegos.Count - 1) == -1)
                    {
                        Console.WriteLine("No Tienes juegos añadidos.");
                    }
                    else
                    {
                        Console.WriteLine("¿Que Videojuego desea eliminar? (Elija numero de 0 - " + (ArrayVideojuegos.Count - 1 + ")"));
                        seleccion = Convert.ToInt32(Console.ReadLine());
                        ArrayVideojuegos.RemoveAt(seleccion);
                        Console.WriteLine("Eliminando...");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    string nombre;
                    Console.WriteLine("Elige un Videojuego para comprobar su" +
                        " existencia y mirar sus datos (Elige un Videojuego de 0 - " + (ArrayVideojuegos.Count - 1) + ")\n" +
                        "Dime el nombre del Videojuego:");
                    nombre = Console.ReadLine();
                    foreach (Videojuegos v in ArrayVideojuegos)
                    {
                        if (nombre == v.Titulo)
                        {
                            Console.Write("El Videojuego ya Existe \nNombre: " + v.Titulo + "\nFabricante: " + v.Fabricante + "\nAño: " + v.Año + "\nCategoria: " + v.Est + "\n");
                        }
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Lista de videojuegos");
                    foreach(Videojuegos v in ArrayVideojuegos){
                        Console.WriteLine("Titulo: " + v.Titulo + "" +
                            "  Fabricante: " + v.Fabricante + "" +
                            "  Año: " + v.Año + "" +
                            "  Categoria: " + v.Est);
                        Console.ReadKey();
                    }
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

        public eEstilo Categoria()
        {
            string letra;
            do
            {
                Console.Write("Elige categoria (-a Arcade, -v VideoAventura, -s Shootemup, -e Estrategia, -d Deportivo)\n" +
                        "D) Categoria: ");
                letra = Console.ReadLine();

                if (letra.ToLower() == "a")
                {
                    return eEstilo.Arcade;
                }
                else if (letra.ToLower() == "v")
                {
                    return eEstilo.Videoaventura;
                }
                else if (letra.ToLower() == "s")
                {
                    return  eEstilo.Shootemup;
                }
                else if (letra.ToLower() == "e")
                {
                    return  eEstilo.Estrategia;
                }
                else if (letra.ToLower() == "d")
                {
                    return eEstilo.Deportivo;
                }
                else
                {
                    Console.WriteLine("No has especificado ninguna opcion valida para la categoria prueba otra vez");
                }
            } while (letra.ToLower() != "a" && letra.ToLower() != "v" && letra.ToLower() != "s" && letra.ToLower() != "e"  && letra.ToLower() != "d");
                return eEstilo.Arcade;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            while (Salir != 8)
            {
                p1.Selection(p1.Menu());
            }
            Console.ReadKey();
        }
    }
} 