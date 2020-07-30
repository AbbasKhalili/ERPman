
namespace Basicinfo.Application.Contract.InvoiceSale
{
    public class SelectInvoiceSaleChildQuery
    {
        public long Id { get; set; }
        public long InvoiceSaleId { get; set; }
        public long GoodsId { get; set; }
        public float Counts { get; set; }
        public float Price { get; set; }
    }
}
