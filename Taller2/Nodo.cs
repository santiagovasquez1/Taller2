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
            set { nombre = value; ExportarPropiedades(Valor: nombre); }
        }

        public List<Enlace> enlaces { get; set; } = new List<Enlace>();
        public List<Tuple<string, object>> Propiedades = new List<Tuple<string, object>>();

        public abstract void FuncionGeo();

        public List<Enlace> GetEnlaces()
        {
            var tempEnlaces = new List<Enlace>();
            return tempEnlaces;
        }

        public void ExportarPropiedades([CallerMemberName] string Name = null, object Valor = null)
        {
            var Temp = new Tuple<string, object>(Name, Valor);
            Propiedades.Add(Temp);
        }
    }
}