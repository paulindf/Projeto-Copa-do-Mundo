using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    [Table("SELECAO")]
    public class Selecao : Generico
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Pais { get; set; }

        [Required]
        [MaxLength(100)]
        public string Tecnico { get; set; }
        public virtual List<Jogador> Jogadores { get; set; }

        [Required]
        [Column("UsuarioCadastro")]
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}