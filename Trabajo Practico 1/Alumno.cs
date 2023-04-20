using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1
{
    internal class Alumno
    {
        private string nombre;
        private int legajo;
        private string apellido;

        public Alumno(string nombre, string apellido , int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        override
        public string ToString()
        {
            return nombre+apellido;
        }
    }
}
