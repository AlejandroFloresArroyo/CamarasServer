using System;
using System.Collections.Generic;

namespace CamKyscn.Entities
{
    public class Paquete
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
        public HashSet<Banda> bandas {get;set;}
    }
}