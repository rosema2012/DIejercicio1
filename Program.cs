
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
        string Titulo;
        string Fabricante;

        int Año;

        enum Estilo
        {
            Arcade,
            Videoaventura,
            Shootemup,
            Estrategia,
            Deportivo
        };

        ArrayList Videojuegos = new ArrayList();

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
            int seleccion;
            seleccion = num;
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
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
                    Console.WriteLine("8");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Selection(p1.Menu());
            Console.ReadKey();
        }
    }
}
