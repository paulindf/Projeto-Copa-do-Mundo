using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Copa_do_Mundo.Models.Data
{
    public class SelecaoRepository : Repository<Selecao>
    {
        private Contexto _db;
        public SelecaoRepository(Contexto contexto) : base(contexto) => _db = contexto;


    }
}