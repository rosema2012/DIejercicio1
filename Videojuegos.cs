using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiEjercicio1
{
    class Videojuegos
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

        private Estilo estilox;

        public Videojuegos ()
        {
            this.Titulo = "Juego";
            this.Fabricante = "JaponesesSeguro";
            this.Año = 1994;
            this.estilox = Estilo.Arcade;
        }
        public Videojuegos (string nombre, string fabricante,int año)
        {
            this.Titulo = nombre;
            this.Fabricante = fabricante;
            this.Año = año;
        }
    }
}
