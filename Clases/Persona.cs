using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolad.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void ImprimirPersona()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }
}
