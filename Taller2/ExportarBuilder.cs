using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    /// <summary>
    /// Clase encargada de la creación de las clases
    /// especificas de Exportación, esto para quitarle
    /// la responsabilidad de instanciación a la clase
    /// CVisitante
    /// </summary>
   public  class ExportarBuilder
    {
        private IExportar Exportar;
        private TipoArchivo TipoArchivo;
        public ExportarBuilder(TipoArchivo tipo)
        {
            TipoArchivo = tipo;
        }
        public IExportar CrearExportador()
        {
            if (TipoArchivo == TipoArchivo.XML)
                Exportar = new GrafoXML();
            return Exportar;
        }
    }
}
