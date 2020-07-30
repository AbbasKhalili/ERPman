using System.Collections.Generic;
using System.Linq;
using Basicinfo.Application.Contract.GoodsType;
using Basicinfo.Application.Contract.InvoiceSale;
using Basicinfo.Domain.Model.InvoiceSale;
using Framework.Application;

namespace Basicinfo.Application.InvoiceSale
{
    public class InvoiceSaleQueryHandler : IQueryHandler<SelectInvoiceSaleQuery>
    {
        private readonly IInvoiceSaleRepository _invoiceSaleRepository;

        public InvoiceSaleQueryHandler(IInvoiceSaleRepository invoiceSaleRepository)
        {
            _invoiceSaleRepository = invoiceSaleRepository;
        }


        List<SelectInvoiceSaleQuery> IQueryHandler<SelectInvoiceSaleQuery>.Handle()
        {
            var ss = _invoiceSaleRepository.GetAll();
            var tmp = ss.ToList();
            var result = new List<SelectInvoiceSaleQuery>();
            foreach (var itm in tmp)
            {
                result.Add(new SelectInvoiceSaleQuery()
                {
                    Id = itm.Id,
                    InvoiceDate = itm.InvoiceDate,
                    SeqId = itm.SeqId,
                    TotalSum = itm.TotalSum,
                    DateSave = itm.DateSave,
                    UserSave = itm.UserSave,
                    //Children = new List<SelectInvoiceSaleChildQuery>( )
                });
            }
            return result;
        }
    }
}
