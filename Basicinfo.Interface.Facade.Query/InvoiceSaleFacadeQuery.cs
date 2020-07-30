using System.Collections.Generic;
using System.Linq;
using Basicinfo.Application.Contract.InvoiceSale;
using Basicinfo.Interface.Facade.Contract;
using Framework.Application;

namespace Basicinfo.Interface.Facade.Query
{
    public class InvoiceSaleFacadeQuery : IInvoiceSaleFacadeQuery
    {
        private readonly ICommandBus _bus;

        public InvoiceSaleFacadeQuery()
        {
            _bus = new CommandBus();
        }

        public List<SelectInvoiceSaleQuery> GetAll()
        {
            return _bus.GetData<SelectInvoiceSaleQuery>().ToList();
        }
    }
}
