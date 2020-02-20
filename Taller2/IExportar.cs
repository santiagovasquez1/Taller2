namespace Taller2
{
    public interface IExportar
    {
        void CrearDocumento();

        void SalvarDocumento();

        void ExportarNodo(Nodo nodo, string Padre);

        void ExportarEnlace(Enlace enlace, string Padre);
    }
}