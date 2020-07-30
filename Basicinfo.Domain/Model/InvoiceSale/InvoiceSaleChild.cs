
namespace Basicinfo.Domain.Model.InvoiceSale
{
    public sealed class InvoiceSaleChild 
    {
        public long Id { get; set; }
        public long InvoiceSaleId { get; set; }
        public long GoodsId { get; set; }
        public float Counts { get; set; }
        public float Price { get; set; }

        public InvoiceSale InvoiceSale { get; set; }


        public InvoiceSaleChild() { } 

        public InvoiceSaleChild(long invoiceSaleId ,long goodsId, float counts, float price)
        {
            InvoiceSaleId = invoiceSaleId;
            GoodsId = goodsId;
            Counts = counts;
            Price = price;
        }

        public InvoiceSaleChild(long id, long invoiceSaleId, long goodsId, float counts, float price)
        {
            Id = id;
            InvoiceSaleId = invoiceSaleId;
            GoodsId = goodsId;
            Counts = counts;
            Price = price;
        }
    }
}
