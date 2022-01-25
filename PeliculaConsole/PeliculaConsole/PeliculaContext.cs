using Microsoft.EntityFrameworkCore;
using PeliculaConsole.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculaConsole
{
    public class PeliculaContext : DbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-EEMSH3I9\\SQLEXPRESS;Database=PeliculasConsole;User Id=sa;Password=Omar285502;MultipleActiveResultSets=true");
        }
    }
}
