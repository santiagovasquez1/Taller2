using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public class Industria : Nodo
    {
        public double[] Coord { get; set; }

        public Industria(string nombre, double[] coord)
        {
            Nombre = nombre;
            Coord = coord;
        }
        public override void FuncionGeo()
        {
            Console.WriteLine($"X: {Coord[0]}, Y: {Coord[1]}");
        }
        public override string ToString()
        {
            return ($"Industria_{Nombre}");
        }
    }
}