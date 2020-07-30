using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Basicinfo.Application.Contract.InvoiceSale;
using Basicinfo.Domain.Model.InvoiceSale;
using Basicinfo.Interface.Facade.Contract;
using Basicinfo.Interface.Facade.Query;
using Framework.Application;

namespace ERPman.Controllers
{
    public class InvSaleController : Controller
    {
        public readonly ICommandBus Bus;
        public readonly IInvoiceSaleFacadeQuery Query;

        public InvSaleController()
        {
            Bus = new CommandBus();
            Query = new InvoiceSaleFacadeQuery();
        }

        public ActionResult Index()
        {
            Bus.GetData<SelectInvoiceSaleQuery>();
            return View();
        }

        [HttpPost]
        public ActionResult Save(CreateInvoiceSaleCommand model)
        {
            model.Children.Add(new InvoiceSaleChild(0,100, 1, 2000));
            model.Children.Add(new InvoiceSaleChild(0,101, 2, 5000));
            
            Bus.Dispatch(model);
            return View();
        }

        [HttpPost]
        public ActionResult Update(UpdateInvoiceSaleCommand model)
        {
            model.Children.Add(new InvoiceSaleChild(5,model.SeqId, 8900, 11, 12002));
            model.Children.Add(new InvoiceSaleChild(6,model.SeqId, 7950, 22, 15005));
            model.Children.Add(new InvoiceSaleChild(0, model.SeqId, 8008, 100, 414141));

            Bus.Dispatch(model);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(DeleteInvoiceSaleCommand model)
        {
            //model.Children.Add(new InvoiceSaleChild(5, model.SeqId, 8900, 11, 12002));
            //model.Children.Add(new InvoiceSaleChild(6, model.SeqId, 7950, 22, 15005));
            //model.Children.Add(new InvoiceSaleChild(0, model.SeqId, 8008, 100, 414141));

            Bus.Dispatch(model);
            return View();
        }
    }
}