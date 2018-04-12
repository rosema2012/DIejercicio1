#define Lanzador

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
        eEstilo Estilo;


        public int Menu()
        {
            int seleccion = 0;
            try
            {
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
                Console.Clear();
                return seleccion;
            }
            catch (FormatException)
            {
                Console.WriteLine("Opcion no valida prueba de nuevo una eleccion valida");
                Console.ReadKey();
                Console.Clear();
            }
            return seleccion;
        }

        public void Selection(int num)
        {
            string titulo, fabricantes;
            int seleccion, año;
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
                    Console.Clear();
                    break;
                case 2:
                    try
                    {
                        if ((ArrayVideojuegos.Count - 1) == -1)
                        {
                            Console.WriteLine("No Tienes juegos añadidos.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("¿Que Videojuego desea eliminar? (Elija numero de 0 - " + (ArrayVideojuegos.Count - 1 + ")"));
                            seleccion = Convert.ToInt32(Console.ReadLine());
                            ArrayVideojuegos.RemoveAt(seleccion);
                            Console.WriteLine("Eliminando...");
                            Console.ReadKey();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Pon un valor valido");
                        Console.ReadKey();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("No existe un juego en esa posicion");
                        Console.ReadKey();
                    }
                    Console.Clear();
                    break;
                case 3:
                    string nombre;
                    bool juego = true;
                    if (ArrayVideojuegos.Count == 0)
                    {
                        Console.WriteLine("No hay Videojuegos en la lista");
                    }
                    else {
                        Console.WriteLine("============================================================================================\n" +
                            "Elige un Videojuego para comprobar su" +
                            " existencia y mirar sus datos (Ahora mismo hay " + (ArrayVideojuegos.Count) + ")\n" +
                            "============================================================================================\n" +
                            "Dime el nombre del Videojuego:");
                        nombre = Console.ReadLine();
                        Console.Clear();
                        foreach (Videojuegos v in ArrayVideojuegos)
                        {
                            if (nombre.ToLower().Trim() == v.Titulo.ToLower())
                            {
                                string videogame = String.Format("El videojuego ya existe \n Nombre: {0,-10} Fabricante: {1,-10} Año: {2,-10} Categoria: {3,-10}",v.Titulo,v.Fabricante,v.Año,v.Est);
                                Console.WriteLine(videogame);
                                juego = false;
                            }
                        }
                        if (juego)
                        {
                            Console.WriteLine("El juego no existe");
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("Lista de videojuegos");
                    if (ArrayVideojuegos.Count == 0)
                    {
                        Console.WriteLine("La lista esta vacia");
                    }
                    else
                    {
                        foreach (Videojuegos v in ArrayVideojuegos)
                        {
                            string juegos = String.Format("Titulo: {0,-15} Fabricante: {1,-10} Año: {2,-5} Categoria: {3,-10}", v.Titulo, v.Fabricante, v.Año, v.Est);
                            Console.WriteLine(juegos);
                            Console.ReadKey();
                        }
                    }
                    Console.Clear();
                    break;
                case 5:
                    bool juego2 = false;
                    try
                    {
                        Console.WriteLine("============================\nBuscando juegos por FILTRO\n============================\n" +
                            "Dime un año para filtrar los juegos de ese año: ");
                        int Filtroaños = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Dime el estilo por el cual quieres filtrar");
                        eEstilo category = Categoria();
                        foreach (Videojuegos v in ArrayVideojuegos)
                        {
                            if (v.Año == Filtroaños && v.Est == category)
                            {
                                string juegos = String.Format("Titulo: {0,-15} Fabricante: {1,-10} Año: {2,-5} Categoria: {3,-10}", v.Titulo, v.Fabricante, v.Año, v.Est);
                                Console.WriteLine(juegos);
                                juego2 = true;
                            }
                        }
                        if (!juego2)
                        {
                            Console.WriteLine("No hay ningun juego con esas filtraciones");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Elige alguna fecha o año");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    int pos;
                    try
                    {
                        if (ArrayVideojuegos.Count == 0)
                        {
                            Console.WriteLine("No hay juegos en la lista");
                        }
                        else
                        {
                            Console.WriteLine("Dime un juego que modificar (Hay desde 0 a " + (ArrayVideojuegos.Count - 1) + ")");
                            pos = Convert.ToInt32(Console.ReadLine());
                            Console.Write("============================\n" +
                            "    Modificar Videojuego    =" +
                            "   \n============================\n" +
                            "a) Titulo: ");
                            titulo = Console.ReadLine();
                            Console.Write("b) Fabricante: ");
                            fabricantes = Console.ReadLine();
                            Console.Write("c) año: ");
                            año = Convert.ToInt32(Console.ReadLine());
                            Estilo = Categoria();
                            ArrayVideojuegos[pos] = new Videojuegos(titulo, fabricantes, año, Estilo);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No es una seleccion valida");
                    }catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("No existe la posicion elegida");
                    }
                    Console.Clear();
                    break;
                case 7:
                    if (ArrayVideojuegos.Count == 0)
                    {
                        Console.WriteLine("La lista esta vacia ya");
                    }
                    else
                    {
                        ArrayVideojuegos.Clear();
                        Console.WriteLine("Removiendo toda la lista...");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:

                    Console.WriteLine("Estas saliendo del programa...");
                    Salir = 8;
                    break;
            }
        }

        public eEstilo Categoria()
        {
            int num;
            do
            {
                Console.Write("Elige categoria (0 Arcade, 1 VideoAventura, 2 Shootemup, 3 Estrategia, 4 Deportivo)\n" +
                        "D) Categoria: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0 || num > 4);
            return (eEstilo)num;
        }

        public void Lanzador()
        {
#if (Lanzador)
            {
                ArrayVideojuegos.Add(new Videojuegos("Spyro","Sky",1994,eEstilo.Arcade));
                ArrayVideojuegos.Add(new Videojuegos("Skyrim", "Lords", 2008, eEstilo.Shootemup));
                ArrayVideojuegos.Add(new Videojuegos("Need For Speed", "Origin", 2002, eEstilo.Deportivo));
            }
#elif (!Lanzador)
            {

            }
#endif
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Lanzador();
            while (Salir != 8)
            {
                p1.Selection(p1.Menu());
            }
            Console.ReadKey();
        }
    }
}