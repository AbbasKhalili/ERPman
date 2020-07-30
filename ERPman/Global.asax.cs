using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framework.CastleWindsor;
using Framework.Core;

namespace ERPman
{
    public partial class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //IControllerFactory factory = new MVCControllerFactory("ERPman");
            //ControllerBuilder.Current.SetControllerFactory(factory);

            //IControllerFactory factory = new CustomControllerFactory();
            //ControllerBuilder.Current.SetControllerFactory(factory);


            var container = new WindsorContainer();
            Basicinfo.Wireup.Configurator.Config(container);

            

            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorControllerActivator(container));

            GlobalConfiguration.Configure(WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
