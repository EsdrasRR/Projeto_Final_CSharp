using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLibrary
{
	public class Serie
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID_Serie;
		[Required, StringLength(30)]
		public string Nome { get; set; }
		[Required, StringLength(30)]
		public string Status { get; set; }
		[Required]
		public string Tot_Ep { get; set; }
		[Required]
		public string Ep_Atual { get; set; }
        [Required, StringLength(30)]
        public string Genero1 { get; set; }
        [Required, StringLength(30)]
        public string Genero2 { get; set; }
        [Required, StringLength(30)]
        public string Genero3 { get; set; }
		[Required]
		public string Nota { get; set; }

    }
}
