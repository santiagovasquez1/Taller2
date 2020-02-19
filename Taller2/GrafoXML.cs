using System.Xml;

namespace Taller2
{
    public class GrafoXML : Exportar
    {
        public GrafoXML(IComponente componente) : base(componente)
        {
            ExportarGrafo();
        }

        public override void ExportarGrafo()
        {
            XmlDocument document = new XmlDocument();
            XmlElement raiz = document.CreateElement("Grafo");
            document.AppendChild(raiz);

            foreach (var nodo in ComponenteConcreto.Nodos)
            {
                XmlElement nodoi = document.CreateElement(nodo.ToString());
                raiz.AppendChild(nodoi);

                if (nodo.enlaces != null)
                {
                    foreach (var enlace in nodo.enlaces)
                    {
                        XmlElement enlacei = document.CreateElement("Enlace");
                        enlacei.AppendChild(document.CreateTextNode(enlace.ToString()));
                        nodoi.AppendChild(enlacei);
                    }
                }
            }

            if (ComponenteConcreto.Enlaces != null)
            {
                foreach (var enlacei in ComponenteConcreto.Enlaces)
                {
                    XmlElement enlace = document.CreateElement(enlacei.ToString());
                    raiz.AppendChild(enlace);

                    XmlElement origen = document.CreateElement("origen");
                    origen.AppendChild(document.CreateTextNode(enlacei.Origen.ToString()));
                    XmlElement Destino = document.CreateElement("Destino");
                    Destino.AppendChild(document.CreateTextNode(enlacei.Destino.ToString()));

                    enlace.AppendChild(origen);
                    enlace.AppendChild(Destino);
                }
            }

            document.Save("Prueba.xml");
        }
    }
}