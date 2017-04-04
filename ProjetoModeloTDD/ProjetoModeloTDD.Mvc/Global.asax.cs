using ProjetoModeloTDD.Mvc.AutoMapper;
using ProjetoModeloTDD.Mvc.Ninject;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoModeloTDD.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
            //ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

        }
    }
}
