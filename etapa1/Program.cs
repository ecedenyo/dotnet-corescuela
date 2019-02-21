using System;
using CorEscuela.Entidades;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2019);
            escuela.Pais = "Panamá";
            escuela.Ciudad = "Panamá";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            Console.WriteLine(escuela);
        }
    }
}
