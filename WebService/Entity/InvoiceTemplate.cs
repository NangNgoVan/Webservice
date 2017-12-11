using System;
using System.Collections.Generic;

namespace WebService.Entity
{
    /// <summary>
    /// Mau hoa don
    /// </summary>
    public class InvoiceTemplate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Number { get; set; } //001
        public string Serial { get; set; } //PT/17E
        public string Status { get; set; }

        public string PatternName { get; set; } //Mau in hoa don (01GTKT-01.cshtml)

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }

        //FK
        public int IdInvoiceType { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }
        
        //public virtual ICollection<RegisterTemplateInvoice> RegisterTemplateInvoices { get; set; }
        //public virtual ICollection<AccountTokenTemplate> AccountTokenTemplates { get; set; }
    }
}
