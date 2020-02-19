using System.Collections.Generic;

namespace Taller2
{
    public abstract class Exportar : IComponente
    {
        public IComponente ComponenteConcreto;
        public List<Nodo> Nodos { get; set; }
        public List<Enlace> Enlaces { get; set; }

        public Exportar(IComponente componente)
        {
            ComponenteConcreto = componente;
        }

        public virtual void ExportarGrafo()
        {
        }
    }
}