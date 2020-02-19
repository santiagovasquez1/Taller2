using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public abstract class  Nodo
    {
        public string Nombre { get; set; }
        public List<Enlace> enlaces { get; set; }

        public abstract void FuncionGeo();

        public List<Enlace> GetEnlaces()
        {
            var tempEnlaces = new List<Enlace>();
            return tempEnlaces;
        }
    }
}