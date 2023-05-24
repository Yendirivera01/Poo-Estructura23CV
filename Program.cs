using consolad.Clases;
using System;

namespace Herencia22CV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona lePesona = new Persona();
            lePesona.Nombre = "Cochiloco";
            lePesona.Edad = 33;
            Console.WriteLine($"Los datos de {lePesona.Nombre} son");
            lePesona.ImprimirPersona();
            Empleado yo = new Empleado();
            yo.Edad = 12;
            yo.Nombre = "Matias";
            yo.Sueldo = 22222222;

            Console.WriteLine($"Los datos de la {yo.Nombre} son:");
            yo.Imprimir();
        }
    }
}
