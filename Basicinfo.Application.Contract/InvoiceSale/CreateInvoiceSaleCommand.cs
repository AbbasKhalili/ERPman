using System;
using System.Collections.Generic;
using Basicinfo.Domain.Model.InvoiceSale;
using Framework.Core;

namespace Basicinfo.Application.Contract.InvoiceSale
{
    public class CreateInvoiceSaleCommand : ICommand
    {
        public DateTime InvoiceDate { get; set; }
        public float TotalSum { get; set; }

        public List<InvoiceSaleChild> Children { get; set; }

        public CreateInvoiceSaleCommand() { Children = new List<InvoiceSaleChild>(); }
    }
}
