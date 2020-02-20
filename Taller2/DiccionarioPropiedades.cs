using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Taller2
{
    /// <summary>
    /// Clase que se encarga de exponer cada una de las propiedades 
    /// concretas de las clases tipo Nodos, esto para que las clases nodos 
    /// no sean modificadas y las clases que se encargen de exportar la 
    /// estructura del nodo, sepan las propiedeades de estos.
    /// </summary>
    public class DiccionarioPropiedades 
    {
        public static Dictionary<string, object> Propiedades(Nodo claseBase)
        {
            Dictionary<string, object> propiedades = new Dictionary<string, object>();
            Type myType = claseBase.GetType();
            PropertyInfo[] myPropInfos = myType.GetProperties();

            foreach (PropertyInfo propiedad in myPropInfos)
            {
                if(propiedad.GetValue(claseBase) != null && propiedad.Name!="enlaces")
                propiedades.Add(propiedad.Name, propiedad.GetValue(claseBase));
            }
            return propiedades;
        }
    }
}