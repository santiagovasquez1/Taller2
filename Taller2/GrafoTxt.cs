using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public class GrafoTxt : Exportar
    {
        public GrafoTxt(IComponente componente) : base(componente)
        {
        }

        public override void ExportarGrafo()
        {
            foreach(var prueba in ComponenteConcreto.Nodos)
            {

            }
        }
    }
}