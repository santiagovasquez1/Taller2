using System;
using System.Runtime.CompilerServices;

namespace Taller2
{
    public class Ciudad : Nodo
    {
        private int poblacion;

        public int Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }

        public Ciudad(string nombre, int poblacion)
        {
            Nombre = nombre;
            Poblacion = poblacion;
        }

        public override void FuncionGeo()
        {
            Console.WriteLine($"{Nombre}, Poblacion : {Poblacion}");
        }

        public override string ToString()
        {
            return ($"Ciudad_{Nombre}");
        }

    }
}