using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2.Visitante
{
    public interface IVisitante
    {
        void Visitar(Grafo grafo,string Mensaje);
        //Visitante de nodos
        void Visitar(Nodo nodo,string Mensaje);
        //Visitante de enlaces
        void Visitar(Enlace enlace, string Mensaje);
    }
}
