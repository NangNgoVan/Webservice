using System;
using System.Collections.Generic;

namespace WebService.Entity
{
    public class InvoiceField
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public string Metadata { get; set; } //Dữ liệu là các attribute của thẻ HTML
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        //FK
        public virtual ICollection<InvoiceExtraDetail> InvoiceExtraDetails { get; set; }
    }
}
