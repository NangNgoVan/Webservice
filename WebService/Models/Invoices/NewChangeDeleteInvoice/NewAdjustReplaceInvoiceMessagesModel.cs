using System;

namespace WebService.Models.Invoices.NewChangeDeleteInvoice
{
    /// <summary>
    /// NewReplaceAdjust
    /// NoticeStateChangedInsuranceInvoice
    /// DeleteInsuranceInvoice
    /// </summary>
    public class NewAdjustReplaceInvoiceMessagesModel
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
        /// ID của hoá đơn trên hệ thống core bảo hiểm
        /// </summary>
        public long InvoiceID { get; set; }

        /// <summary>
        /// Trạng thái của lời gọi: “SUCCESS” Thành công “FAIL”  Thất bại
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Tình trạng lời gọi:
        /// (Trường này trong thay đổi trạng thái hóa đơn)
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
        /// Số hoá đơn trên hệ thống HDĐT (chỉ khi STATUS=SUCCES hoặc (STATUS=FAIL và hoá đơn đã tạo ra từ lời gọi trước đó))
        /// </summary>
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Trạng thái hoá đơn (chỉ khi STATUS=SUCCES hoặc (STATUS=FAIL và hoá đơn đã tạo ra từ lời gọi trước đó))
        /// Initiation/“Dự thảo”
        /// Proposed/“Đang trình phát hành”
        /// Published/“Đã phát hành”
        /// </summary>
        public string InvoiceState { get; set; }
    }
}