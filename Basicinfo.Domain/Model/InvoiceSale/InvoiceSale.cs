using System;
using System.Collections.Generic;
using Framework.Domain;

namespace Basicinfo.Domain.Model.InvoiceSale
{
    public sealed class InvoiceSale : EntityBase, IAggregateRoot
    {
        public long SeqId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public float TotalSum { get; set; }
        public ISet<InvoiceSaleChild> Children { get; set; }

        public InvoiceSale()
        {
            Children = new HashSet<InvoiceSaleChild>();
        }

        public InvoiceSale(long nextId, float totalsum)
        {
            this.SeqId = nextId;
            this.TotalSum = totalsum;
            this.InvoiceDate = DateTime.Now;
            Children = new HashSet<InvoiceSaleChild>();
        }
    }
}
