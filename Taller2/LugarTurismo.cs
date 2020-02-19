using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public class LugarTurismo : Nodo
    {
        public double[] Coord { get; set; }

        public LugarTurismo(string nombre, double[]coord)
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
            return($"Turismo_{Nombre}");
        }
    }
}