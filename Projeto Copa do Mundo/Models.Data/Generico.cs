using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class Generico
    {
        [Required]
        public DateTime DataRegistro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Ativado { get; set; }
    }
}