using System;
using Microsoft.AspNetCore.Http;

namespace CamKyscn.Dtos.Foto
{
    public class AddFotoDTO
    {
        public string CodigoBanda { get; set; }
        public string Locacion { get; set; }
        public DateTime Fecha { get; set; }
        public IFormFile Foto { get; set; }
        public IFormFile Logo { get; set; }
    }
}