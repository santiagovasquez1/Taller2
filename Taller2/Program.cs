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
            Nodo nodo2 = new LugarTurismo("Pueblito_paisa", new double[] { 0.20, 0.15 });
            Nodo nodo3 = new Industria("Coltejer", new double[] { 5.25, 10.15 });
            Nodo nodo4 = new Industria("Colcafe", new double[] { 6.30, 14.5 });


            Enlace enlace1 = new Enlace
            {
                Origen = nodo3,
                Destino = nodo2
            };

            Enlace enlace2 = new Enlace()
            {
                Origen = nodo2,
                Destino = nodo3
            };

            Enlace enlace3 = new Enlace()
            {
                Origen = nodo4,
                Destino = nodo3
            };

            nodo1.enlaces = new Enlace[] { enlace1, enlace2 }.ToList();
            nodo2.enlaces = new Enlace[] { enlace3 }.ToList();

            Nodos.AddRange(new Nodo[] { nodo1, nodo2, nodo3, nodo4 }); 

            MIGrafo.Nodos = Nodos;
            MIGrafo.Enlaces= new Enlace[] { enlace1, enlace2 }.ToList();

            //Imprimir funciones geograficas
            foreach (var nodoi in MIGrafo.Nodos)
                nodoi.FuncionGeo();

            ExportarFactory.ExportarInfoGrafo(MIGrafo, TiposArchivos.XML);
            Console.WriteLine("-----------------");
        }
    }
}
