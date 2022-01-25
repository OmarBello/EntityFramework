using Microsoft.EntityFrameworkCore;
using PeliculaConsole.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculaConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n"+
                    "\n 1.- Crear Genero"+
                    "\n 2.- Visualizar Genero"+
                    "\n 3.- Crear Pelicula"+
                    "\n 4.- Visualizar Peliculas" +
                    "\n 5.- Salir");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        string nombreGenero = "";
                        //int idGenero = 0;

                        Console.Write("Introduzca un genero: ");
                        nombreGenero = Console.ReadLine();

                        using (var context = new PeliculaContext())
                        {
                            var std = new Genero()
                            {
                                Name = nombreGenero
                            };

                            context.Generos.Add(std);
                            context.SaveChanges();
                        }
                        Console.WriteLine();
                        break;
                     
                    case 2:
                        using (var context = new PeliculaContext())
                        {
                            foreach (var genero in context.Generos)
                            {
                                Console.WriteLine(genero.GeneroId+"-"+genero.Name);
                            }
                        }
                        Console.WriteLine();

                        break;

                        

                    case 3:
                        string tituloPelicula = "";
                        string añoPelicula = "";
                        int idGenero = 0;

                        Console.Write("Ingrese el titulo de la pelicula: ");
                        tituloPelicula = Console.ReadLine();
                        Console.Write("Ingrese el año de la pelicula: ");
                        añoPelicula = Console.ReadLine();
                        Console.Write("Ingrese el genero donde se guardara esta pelicula: ");
                        idGenero = Convert.ToInt32(Console.ReadLine());

                        using (var context3 = new PeliculaContext())
                        {
                            var std = new Pelicula()
                            {
                                GeneroId = idGenero,
                                Titulo = tituloPelicula,
                                Año = añoPelicula
                            };

                            context3.Peliculas.Add(std);
                            context3.SaveChanges();
                        }
                        break;

                    case 4:
                         using (var context4 = new PeliculaContext())
                        {
                           
                            foreach (var pelicula in context4.Peliculas)
                            {
                                foreach (var generos in context4.Generos )
                                {
                                    if(pelicula.GeneroId == generos.GeneroId)
                                    {
                                        Console.WriteLine(pelicula.Titulo + " | " + pelicula.Año + " | " + generos.Name);
                                    }
                                    
                                }
                            }
                        }
                        break;
                }

            } while (opcion != 4);

            

          

            Console.ReadKey();
        }
    }
}
