using System;

namespace WebService.Entity
{
    public class InvoiceNumber
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public int IdInvoiceTemplate { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string Status { get; set; } //enum InvoiceNumberStatus
        public Guid IdInvoiceHeader { get; set; }

        public Guid Owner { get; set; }
        public Guid CreateBy { get; set; }
    }
}
