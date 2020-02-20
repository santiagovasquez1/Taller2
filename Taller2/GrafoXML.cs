using System.Collections.Generic;
using System.Xml;

namespace Taller2
{
    public class GrafoXML : IExportar
    {
        private XmlDocument document;
        private XmlElement raiz;
        private List<XmlElement> Elementos = new List<XmlElement>();

        public void CrearDocumento()
        {
            document = new XmlDocument();
            raiz = document.CreateElement("Grafo");
            document.AppendChild(raiz);

            Elementos.Add(raiz);
        }

        public void SalvarDocumento()
        {
            document.Save("Prueba.xml");            
        }

        public void ExportarNodo(Nodo nodo, string Padre)
        {
            XmlElement nodoi = document.CreateElement(nodo.ToString());
            XmlElement raiz = ExtraerRaiz(Padre);

            var propiedades = DiccionarioPropiedades.Propiedades(nodo);
            Elementos.Add(nodoi);

            foreach (var prop in propiedades)
            {
                XmlElement propi = document.CreateElement(prop.Key);
                propi.AppendChild(document.CreateTextNode(prop.Value.ToString()));
                nodoi.AppendChild(propi);
                Elementos.Add(propi);
            }

            raiz.AppendChild(nodoi);
        }

        private XmlElement ExtraerRaiz(string Padre)
        {
            XmlElement raiz = null;
            raiz = Elementos.FindLast(x => x.LocalName == Padre);
            return raiz;
        }

        public void ExportarEnlace(Enlace enlace, string Padre)
        {
            XmlElement raiz = ExtraerRaiz(Padre);
            XmlElement enlacei = document.CreateElement(enlace.ToString());
            Elementos.Add(enlacei);
            raiz.AppendChild(enlacei);
        }
    }
}