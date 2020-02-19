using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente MIGrafo = new Grafo();  

            List<Nodo> Nodos = new List<Nodo>();
            Nodo nodo1 = new Ciudad("Medellin", 4500000);
            Nodo nodo2 = new LugarTurismo("Pueblito_paisa",new double[] { 0.20,0.15});
            Nodo nodo3 = new Industria("Coltejer", new double[] { 5.25, 10, 15 });

            Nodos.AddRange(new Nodo[] { nodo1, nodo2, nodo3 });

            Enlace enlace1 = new Enlace();
            enlace1.Origen = nodo3;
            enlace1.Destino = nodo2;

            Enlace enlace2 = new Enlace()
            {
                Origen = nodo2,
                Destino = nodo3
            };

            nodo1.enlaces = new Enlace[]{ enlace1,enlace2 }.ToList();

            MIGrafo.Nodos = Nodos;
            MIGrafo.Enlaces= new Enlace[] { enlace1, enlace2 }.ToList();

            ExportarFactory.ExportarInfoGrafo(MIGrafo, TiposArchivos.XML);
            Console.WriteLine("-----------------");
        }
    }
}
