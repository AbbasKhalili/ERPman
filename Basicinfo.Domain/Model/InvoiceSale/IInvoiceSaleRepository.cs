using Framework.Domain;

namespace Basicinfo.Domain.Model.InvoiceSale
{
    public interface IInvoiceSaleRepository : IRepository<InvoiceSale>
    {
        long GetNextId();
    }
}
