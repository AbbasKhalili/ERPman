using System.Web.Mvc;
using Basicinfo.Interface.CommandController;
using Basicinfo.Interface.Facade.Contract;
using Basicinfo.Interface.Facade.Query;
using Framework.Application;

namespace ERPman
{
    public class BaseController : Controller
    {
        //public readonly ICommandBus Bus;

        //public BaseController()
        //{
        //    Bus = new CommandBus();
        //}

        public readonly IGoodsTypeLuncher Luncher;
        public readonly IGoodsTypeFacadeQuery Query;

        public BaseController()
        {
            Query = new GoodsTypeFacadeQuery();
            Luncher = new GoodsTypeLuncher();
        }
    }
}