using System;
using CamKyscn.Entities;

namespace CamKyscn.Dtos.Paquete
{
    public class GetPaqueteDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Comprado { get; set; }

        public Banda[] Bandas { get; set; }

    }
}