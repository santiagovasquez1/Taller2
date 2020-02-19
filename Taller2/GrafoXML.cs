using System.Xml;

namespace Taller2
{
    
    public class GrafoXML : Exportar
    {
        private XmlDocument document;
        private XmlElement raiz;

        public GrafoXML(IComponente componente) : base(componente)
        {
            ExportarGrafo();
        }

        public override void ExportarGrafo()
        {
            document = new XmlDocument();
            raiz = document.CreateElement("Grafo");
            document.AppendChild(raiz);

            foreach (var nodo in ComponenteConcreto.Nodos)
            {
                AutoReccorer(nodo,raiz);
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

        public void AutoReccorer(Nodo nodo ,XmlElement praiz)
        {
            XmlElement nodoi = document.CreateElement(nodo.ToString());

            foreach(var prop in nodo.Propiedades)
            {
                XmlElement propi= document.CreateElement(prop.Item1);
                propi.AppendChild(document.CreateTextNode(prop.Item2.ToString()));
                nodoi.AppendChild(propi);
            }
            
            praiz.AppendChild(nodoi);

            if (nodo.enlaces != null)
            {
               foreach(var enlace in nodo.enlaces)
                {
                    XmlElement enlacei = document.CreateElement(enlace.ToString());
                    nodoi.AppendChild(enlacei);
                    AutoReccorer(enlace.Origen,enlacei);
                    AutoReccorer(enlace.Destino,enlacei);
                }
            }
        }
    }
}