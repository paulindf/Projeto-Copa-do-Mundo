using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    [Table("AUDITORIA")]
    public class Auditoria
    {
        [Key]
        public Int64 AuditoriaId { get; set; }

        [MaxLength(20)]
        public string IP { get; set; }

        public int? UsuarioId { get; set; }
        //public Usuario Usuario { get; set; }

        [MaxLength(1000)]
        public string Get { get; set; }

        public string Post { get; set; }

        [MaxLength(50)]
        public string SessionId { get; set; }

        [MaxLength(1000)]
        public string Sessao { get; set; }

        public DateTime DataRegistro { get; set; } = DateTime.Now;

        [MaxLength(500)]
        public string Url { get; set; }
    }
}