using System;

namespace WebService.Models.invoices.NewReplaceAdjustInvoice
{
    public class ReplaceInsuranceInvoiceMessagesModel
    {
        /// <summary>
        /// ID của thông điệp
        /// </summary>
        public long MessageID { get; set; }

        /// <summary>
        /// Thời điểm gửi thông điệp
        /// </summary>
        public long MessageTime { get; set; }

        /// <summary>
        /// ID của hoá đơn thay thế trên hệ thống core bảo hiểm
        /// </summary>
        public long ReplacedInvoiceID { get; set; }

        /// <summary>
        /// Trạng thái của lời gọi:
        /// “SUCCESS” Thành công
        /// “FAIL” Thất bại
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Mã lỗi (chỉ khi STATUS=FAIL)
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Miêu tả lỗi (chỉ khi STATUS=FAIL)
        /// </summary>
        public string ErrorDesc { get; set; }

        /// <summary>
        /// Số của hoá đơn thay thế trên hệ thống HDĐT
        /// </summary>
        public string ReplacedInvoiceNo { get; set; }
    }
}