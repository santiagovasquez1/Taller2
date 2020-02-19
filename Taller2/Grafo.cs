using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public class Grafo:IComponente
    {
        public List<Nodo> Nodos { get; set; }
        public List<Enlace> Enlaces { get; set; }

        public  void ExportarGrafo()
        {
          
        }
    }
}