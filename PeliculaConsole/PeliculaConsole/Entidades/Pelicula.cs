using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculaConsole.Entidades
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public int GeneroId { get; set; }
        public string Titulo { get; set; } 
        public string Año { get; set; } 
        public Genero Genero { get; set; } 
    }
}
