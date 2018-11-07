using Projeto_Copa_do_Mundo.Filtros;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filtro());
        }
    }
}
