using System;

namespace Taller2.Visitante
{
    public class CVisitante : IVisitante
    {
        public IExportar Exportar { get; set; }

        public CVisitante(Grafo grafo,IExportar exportar)
        {
            Exportar = exportar;
            Visitar(grafo, "Visitando Grafo");
        }

        public void Visitar(Nodo nodo, string Raiz)
        {
            Exportar.ExportarNodo(nodo, Raiz);

            if (nodo.enlaces != null)
            {
                foreach (var enlace in nodo.enlaces)
                {
                    Visitar(enlace, nodo.ToString());
                }
            }
        }

        public void Visitar(Enlace enlace, string Raiz)
        {
            Exportar.ExportarEnlace(enlace, Raiz);
            Visitar(enlace.Origen, enlace.ToString());
            Visitar(enlace.Destino, enlace.ToString());
        }

        public void Visitar(Grafo grafo, string Mensaje)
        {
            Exportar.CrearDocumento();

            if (grafo.Nodos != null)
            {
                foreach (var nodo in grafo.Nodos)
                {
                    Visitar(nodo, "Grafo");
                }
            }

            if (grafo.Enlaces != null)
            {
                foreach (var enlace in grafo.Enlaces)
                {
                    Visitar(enlace, "Grafo");
                }
            }

            Exportar.SalvarDocumento();
            
        }
    }
}