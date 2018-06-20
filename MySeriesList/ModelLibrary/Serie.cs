﻿using System.ComponentModel.DataAnnotations;

namespace ModelLibrary
{
    public class Serie
    {
        [Key]
        public int ID_Serie { get; set; }
        [Required, StringLength(30)]
        public string Nome { get; set; }
        [Required]
        public int status { get; set; }
        public int Tot_Ep { get; set; }
        public int Ep_Atual { get; set; }
        public string Genero1 { get; set; }
        public string Genero2 { get; set; }
        public string Genero3 { get; set; }
        public int Nota { get; set; }
        public string Observacao { get; set; }


    }
}
