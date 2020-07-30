using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basicinfo.Application.Contract.InvoiceSale;

namespace Basicinfo.Interface.Facade.Contract
{
    public interface IInvoiceSaleFacadeQuery
    {
        List<SelectInvoiceSaleQuery> GetAll();
    }
}
