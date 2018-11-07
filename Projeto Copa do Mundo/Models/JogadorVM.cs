using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Copa_do_Mundo.Models
{
    public class JogadorVM : GenericoVM
    {
        public int Id { get; set; }

        [Display(Name = "Informe o nome:")]
        [Required(ErrorMessage = "O nome do jogador é obrigatório")]
        [MaxLength(200)]
        public string Nome { get; set; }

        [Display(Name = "Informe a posição:")]
        [Required(ErrorMessage = "A posição do jogador é obrigatória")]
        [MaxLength(200)]
        public string Posicao { get; set; }

        [Display(Name = "Informe a data de nascimento:")]
        [Required(ErrorMessage = "Data de nascimento do jogador é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        public DateTime Nascimento { get; set; }

        public int SelecaoId { get; set; }

        [Display(Name = "Informe o nome da seleção:")]
        public SelecaoVM Selecao { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public virtual UsuarioVM Usuario { get; set; }
    }
}