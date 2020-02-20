using System.Collections.Generic;

namespace Taller2
{
    /// <summary>
    /// Se crea la interfaz IExportar que sera implementada por las
    /// clase que se encargen de exportar el grafo en el tipo de archivo
    /// seleccionado, esto con el fin de flexibilizar el codigo, para nuevos
    /// formatos de exportacion que se quieran implementar en un futuro
    /// </summary>
    public interface IExportar
    {
        void CrearDocumento();

        void SalvarDocumento();

        void ExportarNodo(Nodo nodo, string Padre, Dictionary<string, object> propiedades);

        void ExportarEnlace(Enlace enlace, string Padre);
    }
}