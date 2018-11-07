using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    [Table("USUARIO")]
    public class Usuario : Generico
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(300)]
        [Required]
        public string Nome { get; set; }

        [Required]
        [MaxLength(70)]
        public string Email { get; set; }

        [Required]
        [MaxLength(30)]
        public string Senha { get; set; }
        
    }
}