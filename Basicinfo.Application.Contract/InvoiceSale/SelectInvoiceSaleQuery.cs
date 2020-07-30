using System;
using System.Collections.Generic;
using Framework.Core;

namespace Basicinfo.Application.Contract.InvoiceSale
{
    public class SelectInvoiceSaleQuery : ICommand
    {
        public long Id { get; set; }
        public long SeqId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public float TotalSum { get; set; }

        public string UserSave { get; set; }
        public DateTime DateSave { get; set; }

        //public virtual IList<InvoiceSaleChild> Children { get; set; }
        //public ISet<InvoiceSaleChild> Children = new HashSet<InvoiceSaleChild>();
        //public virtual ISet<SelectInvoiceSaleChildQuery> Children { get; set; }
        public List<SelectInvoiceSaleChildQuery> Children { get; set; }

        public SelectInvoiceSaleQuery()
        {
            Children = new List<SelectInvoiceSaleChildQuery>();
        }
    }
}
