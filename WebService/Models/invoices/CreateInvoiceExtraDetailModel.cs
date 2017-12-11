using System;

namespace WebService.Models.invoices
{
    public class CreateInvoiceExtraDetailModel
    {
        public Guid? IdInvoice { get; set; }

        public int? IdInvoiceField { get; set; }

        public string FieldValue { get; set; }

        public string FieldName { get; set; }

        public string DisplayName { get; set; }

        public string DataType { get; set; }

        public string Metadata { get; set; }
    }
}