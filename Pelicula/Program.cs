using System;

namespace Pelicula
{
    class Peliculas
    {
        public string Titulo;
        public Int16  Año;
        public string Pais;
        public string Director;


    }
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas p1=new Peliculas();
            Peliculas p2=new Peliculas();
             p1.SetTitulo("La La Land");
             p1.SetAño(2016); 
             Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());


            
        }
    }
}
