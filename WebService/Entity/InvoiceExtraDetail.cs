using System;

namespace WebService.Entity
{
    public class InvoiceExtraDetail
    {
        public int Id { get; set; }

        public string FieldValue { get; set; }

        //FK
        public Guid IdInvoiceHeader { get; set; }
        public virtual InvoiceHeader InvoiceHeader { get; set; }

        public int IdInvoiceField { get; set; }
        public virtual InvoiceField InvoiceField { get; set; }
    }
}
