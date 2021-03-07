using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamKyscn.Entities
{
	public class Fotos
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Ruta { get; set; }
		public string Ruta_Demo { get; set; }
		public int PaqueteId { get; set; }
	}
}
