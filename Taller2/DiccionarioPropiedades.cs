using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Taller2
{
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