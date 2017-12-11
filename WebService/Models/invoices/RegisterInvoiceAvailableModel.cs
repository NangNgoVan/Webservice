using System;

namespace WebService.Models.invoices
{
    public class RegisterInvoiceAvailableModel
    {
        /// <summary>
        /// ID lần đăng ký phát hành
        /// </summary>
        public int IdRegisterTemplateInvoice { get; set; }

        /// <summary>
        /// ID mẫu hóa đơn
        /// </summary>
        public int IdInvoiceTemplate { get; set; }

        /// <summary>
        /// Tên mẫu hóa đơn
        /// </summary>
        public string InvoiceTemplateName { get; set; }

        /// <summary>
        /// Ngày sử dụng
        /// </summary>
        public DateTime InvoiceTemplateActiveDate { get; set; }

        /// <summary>
        /// Id Loại hóa đơn
        /// </summary>
        public int IdInvoiceType { get; set; }

        /// <summary>
        /// Number Mẫu hóa đơn
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Serial mẫu hóa đơn
        /// </summary>
        public string Serial { get; set; }

        public DateTime MaxDate { get; set; }

        public DateTime MinDate { get; set; }

    }
}