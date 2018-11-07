using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    [Table("JOGADOR")]
    public class Jogador : Generico
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Posicao { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        public int SelecaoId { get; set; }

        [InverseProperty("Jogadores")]
        public Selecao Selecao { get; set; }

        [Required]
        [Column("UsuarioCadastro")]
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}