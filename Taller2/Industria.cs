using System;

namespace Taller2
{
    public class Industria : Nodo
    {
        private double[] coord;

        public double[] Coord
        {
            get { return coord; }
            set { coord = value; }
        }

        public Industria(string nombre, double[] coord)
        {
            Nombre = nombre;
            Coord = coord;
        }

        public override void FuncionGeo()
        {
            Console.WriteLine($"Industria: {Nombre} X: {Coord[0]}, Y: {Coord[1]}");
        }

        public override string ToString()
        {
            return ($"Industria_{Nombre}");
        }
    }
}