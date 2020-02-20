using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
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
