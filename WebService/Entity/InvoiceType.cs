using System;
using System.Collections.Generic;

namespace WebService.Entity
{
    /// <summary>
    /// Loai hoa don
    /// </summary>
    public class InvoiceType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public string Status { get; set; }

        //FK
        public virtual ICollection<InvoiceTemplate> InvoiceTemplates { get; set; }
        //public virtual ICollection<Pattern> Patterns { get; set; }
    }
}
