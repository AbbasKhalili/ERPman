using System;
using System.Web.Mvc;
using System.Web.Routing;
using Framework.Application;

namespace ERPman
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            ICommandBus bus = new CommandBus();
            IController controller = Activator.CreateInstance(controllerType, bus) as BaseController;
            return controller;
        }
    }
}