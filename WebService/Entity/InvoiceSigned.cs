using System;

namespace WebService.Entity
{
    public class InvoiceSigned
    {
        public Guid Id { get; set; }
        public string Xml { get; set; }
        public DateTime CreateAt { get; set; }

        public Guid Owner { get; set; }
        public Guid CreateBy { get; set; }

        public virtual InvoiceHeader InvoiceHeader { get; set; }
    }
}
