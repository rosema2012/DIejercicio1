using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiEjercicio1
{
    public enum eEstilo
    {
        Arcade,
        Videoaventura,
        Shootemup,
        Estrategia,
        Deportivo
    }
    class Videojuegos
    {
        public string Titulo { set; get; }
        public string Fabricante { set; get; }
        public eEstilo Est { set; get; }
        public int Año;
        public Videojuegos()
        {
            this.Titulo = "Juego";
            this.Fabricante = "JaponesesSeguro";
            this.Año = 1994;
            this.Est = (eEstilo)1;
        }
        public Videojuegos(string nombre, string fabricante, int año, eEstilo Estilo)
        {
            this.Titulo = nombre;
            this.Fabricante = fabricante;
            this.Año = año;
            this.Est = Estilo;
        }
    }
}