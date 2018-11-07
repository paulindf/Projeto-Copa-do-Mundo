using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Copa_do_Mundo.Models
{
    public class SelecaoVM : GenericoVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo País é obrigatório")]
        [MaxLength(100)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "O campo Nome do Técnico é obrigatório")]
        [MaxLength(100)]
        public string Tecnico { get; set; }
        public virtual List<JogadorVM> Jogadores { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public virtual UsuarioVM Usuario { get; set; }
    }
}