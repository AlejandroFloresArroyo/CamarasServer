using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamKyscn.Entities
{
    public class Paquete
    {

        public Paquete()
        {
            Bandas = new List<Banda>();
            Fotos = new List<Foto>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Comprado { get; set; }
        public string Codigo { get; set; }
        public ICollection<Banda> Bandas { get; set; }
        public ICollection<Foto> Fotos { get; set; }
    }
}