using Basicinfo.Application.Contract.InvoiceSale;
using Basicinfo.Domain.Model.InvoiceSale;
using Framework.Application;

namespace Basicinfo.Application.InvoiceSale
{
    public class InvoiceSaleCommandHandler : ICommandHandler<CreateInvoiceSaleCommand>,
        ICommandHandler<UpdateInvoiceSaleCommand>,
        ICommandHandler<DeleteInvoiceSaleCommand>
    {
        private readonly IInvoiceSaleRepository _invoiceSaleRepository;

        public InvoiceSaleCommandHandler(IInvoiceSaleRepository invoiceSaleRepository)
        {
            _invoiceSaleRepository = invoiceSaleRepository;
        }

        public void Handle(CreateInvoiceSaleCommand handle)
        {
            var nextid = _invoiceSaleRepository.GetNextId();
            var inv = new Domain.Model.InvoiceSale.InvoiceSale(nextid,handle.TotalSum);
            foreach (var x in handle.Children)
            {
                inv.Children.Add(new InvoiceSaleChild(nextid,x.GoodsId, x.Counts, x.Price));
            }
            _invoiceSaleRepository.Create(inv);
        }

        public void Handle(UpdateInvoiceSaleCommand handle)
        {
            var inv = new Domain.Model.InvoiceSale.InvoiceSale(handle.SeqId, handle.TotalSum);
            foreach (var x in handle.Children)
            {
                inv.Children.Add(new InvoiceSaleChild(x.Id,handle.SeqId, x.GoodsId, x.Counts, x.Price));
            }
            _invoiceSaleRepository.Update(inv);
        }

        public void Handle(DeleteInvoiceSaleCommand handle)
        {
            var inv = new Domain.Model.InvoiceSale.InvoiceSale(handle.SeqId,0);
            inv.Children.Add(new InvoiceSaleChild(11,handle.SeqId, 0, 0, 0));
            inv.Children.Add(new InvoiceSaleChild(12, handle.SeqId, 101, 2, 5000));
            _invoiceSaleRepository.Delete(inv);
        }
    }
}
