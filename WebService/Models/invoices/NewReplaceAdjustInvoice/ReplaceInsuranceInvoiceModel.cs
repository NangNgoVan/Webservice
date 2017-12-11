using System;

namespace WebService.Models.invoices.NewReplaceAdjustInvoice
{
    public class ReplaceInsuranceInvoiceModel
    {
        /// <summary>
        /// ID của thông điệp
        /// </summary>
        public long MessageID { get; set; }

        /// <summary>
        /// Thời điểm gửi thông điệp
        /// </summary>
        public DateTime MessageTime { get; set; }

        /// <summary>
        /// ID của hoá đơn cần đổi trên hệ thống core bảo hiểm
        /// </summary>
        public long OriginalInvoiceID { get; set; }

        /// <summary>
        /// Số hoá đơn cần đổi trên hệ thống HDĐT
        /// </summary>
        public string OriginalInvoiceNo { get; set; }

        /// <summary>
        /// ID của hoá đơn thay thế trên hệ thống core bảo hiểm
        /// </summary>
        public long ReplacedInvoiceId { get; set; }

        /// <summary>
        /// “Tên” từ màn hình Đổi hoá đơn VAT
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// “Địa chỉ” từ màn hình Đổi hoá đơn VAT
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// “Người GD” từ màn hình Đổi hoá đơn VAT
        /// </summary>
        public string Transactor { get; set; }
    }
    
}