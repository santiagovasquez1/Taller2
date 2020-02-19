using System;

namespace Taller2
{
    public enum TiposArchivos
    {
        XML,
        JSON,
        TXT
    }

    public static class ExportarFactory
    {
        public static Exportar Exportar
        {
            get => default;
            set
            {
            }
        }

        public static IComponente IComponente
        {
            get => default;
            set
            {
            }
        }

        public static void ExportarInfoGrafo(IComponente componente, TiposArchivos formato)
        {
            if (formato == TiposArchivos.XML)
            {
                Exportar = new GrafoXML(componente);                
                Console.WriteLine("Archivo exportado");
            }
        }
    }
}