using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolad.Clases
{
    public class Empleado : Persona
    {
        public float Sueldo { get; set; }
        public void Imprimir()
        {
            base.ImprimirPersona();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }
}
