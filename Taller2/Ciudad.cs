using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public class Ciudad : Nodo
    {
        public int Poblacion { get; set; }

        public Ciudad(string nombre,int poblacion)
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