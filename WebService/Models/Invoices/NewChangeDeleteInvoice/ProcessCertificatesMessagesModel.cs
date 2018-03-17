using System;
using System.Collections.Generic;

namespace WebService.Models.Invoices.NewChangeDeleteInvoice
{
    public class ProcessCertificatesMessagesModel
    {
        /// <summary>
        /// ID của thông điệp
        /// </summary>
        public int MessageID { get; set; }

        /// <summary>
        /// Thời điểm gửi thông điệp
        /// </summary>
        public DateTime MessageTime { get; set; }

        /// <summary>
        /// Trạng thái của lời gọi:
        /// “SUCCESS” Thành công
        /// “FAIL”
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
        /// Group tag cho danh sách các giấy chứng nhận đã huỷ (Chỉ khi STATUS=SUCCESS và có giấy chứng nhận đã huỷ) 
        /// </summary>
        public RemovingCertificates RemovedCertificates { get; set; }

        /// <summary>
        /// Group tag cho danh sách các giấy chứng nhận đã tạo
        /// (Chỉ khi STATUS = SUCCESS và có giấy chứng nhận được tạo mới hoặc thay thê)
        /// </summary>
        public NewCertificatesMessages NewCertificates { get; set; }
    }

    public class NewCertificatesMessages
    {
        /// <summary>
        /// Số giấy chứng nhận đã huỷ.
        /// </summary>
        public List<CertificateMessages> Certificate { get; set; }
    }

    /// <summary>
    /// Tag bắt đầu cho giấy chứng nhận cần tạo
    /// </summary>
    public class CertificateMessages
    {
        /// <summary>
        /// Số giấy chứng nhận mới
        /// </summary>
        public int CertificateNo { get; set; }

        /// <summary>
        /// Số giấy chứng nhận bị thay thế. Nếu có trường này thì giấy chứng nhận mới sẽ thay thế cho giấy chứng nhận cũ với số giấy chứng nhận bị thay thế này
        /// </summary>
        public int ReplacedCertificateNo { get; set; }
    }
}