using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamKyscn.Entities
{
	public class Foto
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Ruta { get; set; }
		public string Ruta_Demo { get; set; }
		public int PaqueteId { get; set; }
	}
}
