using System;
using System.Collections.Generic;
using Basicinfo.Domain.Model.InvoiceSale;
using Framework.Core;

namespace Basicinfo.Application.Contract.InvoiceSale
{
    public class UpdateInvoiceSaleCommand : ICommand
    {
        public long Id { get; set; }
        public long SeqId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public float TotalSum { get; set; }

        public List<InvoiceSaleChild> Children { get; set; }

        public UpdateInvoiceSaleCommand() { Children = new List<InvoiceSaleChild>(); }
    }
}
