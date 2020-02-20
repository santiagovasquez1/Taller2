using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Taller2
{
    public abstract class Nodo
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<Enlace> enlaces { get; set; } 

        public abstract void FuncionGeo();

        public List<Enlace> GetEnlaces()
        {
            var tempEnlaces = new List<Enlace>();
            return tempEnlaces;
        }

    }
}