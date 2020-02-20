using System;

namespace Taller2.Visitante
{
    public class CVisitante : IVisitante
    {
        public IExportar Exportar { get; set; }

        public CVisitante(Grafo grafo)
        {
            Exportar = new GrafoXML();
            Visitar(grafo, "Visitando Grafo");
        }

        public void Visitar(Nodo nodo, string Raiz)
        {
            //Hacer parte imprimir propiedades de los nodos
            Console.WriteLine($"{Raiz}: {nodo.Nombre}");
            Exportar.ExportarNodo(nodo, Raiz);

            if (nodo.enlaces != null)
            {
                foreach (var enlace in nodo.enlaces)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Visitar(enlace, nodo.ToString());
                }
            }
        }

        public void Visitar(Enlace enlace, string Raiz)
        {
            //Hacer parte de imprimir propiedades de los enlaces
            Console.WriteLine($"{Raiz} {enlace.ToString()}");
            Console.ForegroundColor = ConsoleColor.White;

            Exportar.ExportarEnlace(enlace, Raiz);
            Visitar(enlace.Origen, enlace.ToString());
            Visitar(enlace.Destino, enlace.ToString());
        }

        public void Visitar(Grafo grafo, string Mensaje)
        {
            //Hacer parte de imprimir propiedades del grafo
            Exportar.CrearDocumento();

            Console.WriteLine(Mensaje);
            if (grafo.Nodos != null)
            {
                foreach (var nodo in grafo.Nodos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Visitar(nodo, "Grafo");
                }
            }

            if (grafo.Enlaces != null)
            {
                foreach (var enlace in grafo.Enlaces)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Visitar(enlace, "Grafo");
                }
            }

            Exportar.SalvarDocumento();
        }
    }
}