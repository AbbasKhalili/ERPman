using Framework.Core;

namespace Basicinfo.Application.Contract.InvoiceSale
{
    public class DeleteInvoiceSaleCommand : ICommand
    {
        public long Id { get; set; }
        public long SeqId { get; set; }
    }
}
