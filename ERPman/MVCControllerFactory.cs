using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Framework.Application;

namespace ERPman
{
    public class MVCControllerFactory : IControllerFactory
    {
        private readonly string _controllernamespace;

        public MVCControllerFactory(string controllernamespace)
        {
            _controllernamespace = controllernamespace;
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            ICommandBus bus = new CommandBus();
            Type controllerType = Type.GetType(string.Concat(_controllernamespace, ".Controllers.", controllerName, "Controller")) ??
                                  Type.GetType(string.Concat(_controllernamespace, ".Controllers.", "Home", "Controller"));
            if (controllerType != null)
            {
                IController controller = Activator.CreateInstance(controllerType, bus) as Controller;
                return controller;
            }
            return null;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}