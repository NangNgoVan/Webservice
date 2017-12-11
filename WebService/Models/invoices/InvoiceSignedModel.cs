using System;

namespace WebService.Models.invoices
{
    public class InvoiceSignedModel
    {
        public Guid Id { get; set; }

        public string Xml { get; set; }
        public DateTime CreateDate { get; set; }

    }
    
}