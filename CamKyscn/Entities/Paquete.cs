using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamKyscn.Entities
{
    public class Paquete
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Comprado { get; set; }
        public string Codigo { get; set; }
        public List<Banda> Bandas {get;set;}
        public List<Foto> Fotos {get;set;}
    }
}