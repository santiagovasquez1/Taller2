using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Visitante
{
    public interface IVisitante
    {
        /// <summary>
        /// Se crea varias sobrecargas del metodo visitar
        /// cada una para el elemento del grafo que se quiera
        /// recorrer
        /// </summary>
        
        //Visitante del grafo
        void Visitar(Grafo grafo,string Mensaje);
        //Visitante de nodos
        void Visitar(Nodo nodo,string Mensaje);
        //Visitante de enlaces
        void Visitar(Enlace enlace, string Mensaje);
    }
}
