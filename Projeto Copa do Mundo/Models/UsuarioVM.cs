using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_Copa_do_Mundo.Models
{
    public class UsuarioVM : GenericoVM
    {
        public int Id { get; set; }

        [Display(Name = "Informe o nome de usuário")]
        [MaxLength(300)]
        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Informe um email válido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido")]
        [Required(ErrorMessage = "Informe um e-mail válido")]
        [MaxLength(70)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [MaxLength(30)]
        [Display(Name = "Informe uma senha")]
        public string Senha { get; set; }
    }
}