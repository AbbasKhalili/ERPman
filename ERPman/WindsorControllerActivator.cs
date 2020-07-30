using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Castle.Windsor;
using System.Web.Mvc;
using System.Web.Routing;

namespace ERPman
{
    public class WindsorControllerActivator : IHttpControllerActivator
    {
        private readonly IWindsorContainer _container;

        public WindsorControllerActivator(IWindsorContainer container)
        {
            _container = container;
        }
        
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            if (_container.Kernel.HasComponent(controllerType))
            {
                var controller = _container.Resolve(controllerType);
                return controller as IHttpController;
            }
            return null;
        }
    }
}