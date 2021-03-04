using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamKyscn.Entities
{
	public class Foto
	{
		public long Id { get; set; }
		public string Ruta { get; set; }
		public string Ruta_Demo { get; set; }

		public Paquete paquete {get; set;}
	}
}
