using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
    }
}