using System;
using System.Collections.Generic;
using System.Text;

namespace Taller2
{
    public class Enlace
    {
        public string Id { get; set; }
        public Nodo Origen { get; set; }
        public Nodo Destino { get; set; }
        public Enlace()
        {
            Id = Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return$"Enlace_{Id}"; 
        }
    }
}