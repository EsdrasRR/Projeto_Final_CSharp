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
        [Required]
        public int status { get; set; }
        public int Tot_Ep { get; set; }
        public int Ep_Atual { get; set; }
        [Required, StringLength(30)]
        public string Genero1 { get; set; }
        [Required, StringLength(30)]
        public string Genero2 { get; set; }
        [Required, StringLength(30)]
        public string Genero3 { get; set; }
        public int Nota { get; set; }
        [Required, StringLength(100)]
        public string Observacao { get; set; }


    }
}
