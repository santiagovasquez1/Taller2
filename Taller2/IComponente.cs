using System.Collections.Generic;

namespace Taller2
{
    public interface IComponente
    {
        void ExportarGrafo();
        List<Nodo> Nodos { get; set; }
        List<Enlace> Enlaces { get; set; }
    }
}