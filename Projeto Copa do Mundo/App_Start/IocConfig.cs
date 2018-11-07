using Ninject;
using Ninject.Syntax;
using Projeto_Copa_do_Mundo.Models.Data;
using System.Web.Mvc;

namespace Projeto_Copa_do_Mundo.App_Start
{
    public static class IocConfig
    {
        public static void ConfigurarDependencias()
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<UnitOfWork>().To<UnitOfWork>();

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}