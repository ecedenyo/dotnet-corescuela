using System;
using CorEscuela.Entidades;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2019, TiposEscuela.Secundaria, 
                ciudad:"David"
            );
            
            var curso1 = new Curso() {
                Nombre = "101"
            };
            var curso2 = new Curso() {
                Nombre = "201"
            };
            var curso3 = new Curso() {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("==========");
            System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            System.Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            System.Console.WriteLine($"{curso3.Nombre}, {curso3.UniqueId}");
        }
    }
}
