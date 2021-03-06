using System;
using CamKyscn.Entities;

namespace CamKyscn.Dtos.Paquete
{
    public class AddPaqueteDTO
    {
        public DateTime Fecha { get; set; }
        public bool Comprado { get; set; }

        public Banda[] Bandas { get; set; }
    }
}