using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Taller2
{
    public class LugarTurismo : Nodo
    {
        private double[] coord;

        public double[] Coord
        {
            get { return coord; }
            set { coord = value; }
        }

        public LugarTurismo(string nombre, double[]coord)
        {
            Nombre = nombre;
            Coord = coord;
        }
        public override void FuncionGeo()
        {
            Console.WriteLine($"Turismo: {Nombre} X: {Coord[0]}, Y: {Coord[1]}");
        }
        public override string ToString()
        {
            return($"Turismo_{Nombre}");
        }

    }
}