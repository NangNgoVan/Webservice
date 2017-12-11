using System;
using System.Collections.Generic;

namespace WebService.Models.invoices.NewReplaceAdjustInvoice
{
    public class NewReplaceAdjustInvoiceModel
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
        /// Trạng thái của hoá đơn:
        ///Initiation/“Dự thảo”
        ///Proposed/“Đang trình phát hành”
        /// </summary>
        public string InvoiceState { get; set; }

        /// <summary>
        /// Mục đích tạo hóa đơn:
        ///New / “Tạo mới”
        ///Replace / “Thay thế”
        ///Adjust / “Điều chỉnh”
        /// </summary>
        public string Intent { get; set; }

        /// <summary>
        /// ID của hóa đơn bị điều chỉnh/thay thế trong trường hợp phát hành hóa đơn mới để điều chỉnh/thay thế cho hóa đơn cũ
        /// </summary>
        public long OldInvoiceID { get; set; }

        /// <summary>
        /// Lý do thay thế/điều chỉnh hoá đơn đã phát hành cũ
        /// </summary>
        public string ModifiedReason { get; set; }

        /// <summary>
        /// Người GD từ màn hình Phát hành hoá đơn điện tử
        ///Người GD mới thêm vào màn hình Phát hành hóa đơn nhà đồng
        /// Người GD mời thêm vào màn hình Thanh toán đồng bảo hiểm
        /// </summary>
        public string Transactor { get; set; }

        /// <summary>
        /// Mã khách hàng trên hệ thống core bảo hiểm
        /// </summary>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Tên KH từ màn hình Phát hành hoá đơn điện tử
        /// Nhà BH từ màn hình Phát hành hóa đơn nhà đồng
        /// Nhà BH từ màn hình Thanh toán đồng bảo hiểm
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Địa chỉ từ màn hình Phát hành hoá đơn điện tử
        /// Đ.chỉ từ thông tin của nhà bảo hiểm Hệ thống 
        /// => Khách hàng và đối tác 
        /// => Doanh nghiệp bảo hiểm cho Phát hành hóa đơn nhà đồng/Thanh toán đồng bảo hiểm
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Mã thuế từ màn hình Phát hành hoá đơn điện tử
        /// Mã thuế từ thông tin của nhà bảo hiểm Hệ thống
        /// =>Khách hàng và đối tác=>Doanh nghiệp bảo hiểm cho Phát hành hóa đơn nhà đồng/Thanh toán đồng bảo hiểm
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Hình thức thanh toán mới thêm vào trong màn hình Phát hành hoá đơn điện tử
        /// Hình thức thanh toán mới thêm vào màn hình Phát hành hóa đơn nhà đồng
        /// Hình thức thanh toán mới thêm vào màn hình Thanh toán đồng bảo hiểm
        /// </summary>
        public string PayMethod { get; set; }

        /// <summary>
        /// Email mới thêm vào trong màn hình Phát hành hoá đơn điện tử
        /// Email từ màn hình Phát hành hóa đơn nhà đồng hoặc từ thông tin của nhà bảo hiểm Hệ thống 
        /// => Khách hàng và đối tác => Doanh nghiệp bảo hiểm
        /// Email từ màn hình Thanh toán đồng bảo hiểm hoặc từ thông tin của nhà bảo hiểm Hệ thống
        /// => Khách hàng và đối tác =>Doanh nghiệp bảo hiểm
        /// </summary>
        public string Email { get; set; }
        public List<Item> Items { get; set; }

        /// <summary>
        /// Tổng số tiền
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Ngày lập hóa đơn
        /// </summary>
        public DateTime CreatingDate { get; set; }

        /// <summary>
        /// Mã người lập hóa đơn trên core bảo hiểm
        /// </summary>
        public string CreatorCode { get; set; }

        /// <summary>
        /// Mã phòng ban
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Mã chi nhánh/tổng công ty
        /// </summary>
        public string BranchCode { get; set; }
    }

    public class Item
    {
        /// <summary>
        /// Dùng số hợp đồng để xác định tên, ví dụ:
        /// Phí bảo hiểm Xe cơ giới
        /// Phí bảo hiểm Hàng hoá
        /// Dựa vào thông tin hợp đồng để lấy thông tin(X) từ:
        /// -trường Tên của bảng Hệ thống => Mã nghiệp vụ => Mã nghiệp vụ => Mã nghiệp vụ bộ tài chính
        /// Tạo ra tên nghiệp vụ bảo hiểm: Phí bảo hiểm X
        /// Nếu X bắt đầu bằng “Bảo hiểm XYZ” thì xoá “Bảo hiểm” ở đầu thành XYZ sau đó mới tạo ra tên nghiệp vụ bảo hiểm.
        /// </summary>
        public string BusinessLine { get; set; }

        /// <summary>
        /// Số hợp đồng/GCN từ màn hình Phát hành hoá đơn điện tử
        /// HD đầu ra từ màn hình Phát hành hóa đơn nhà đồng/Thanh toán đồng bảo hiểm
        /// </summary>
        public string PolicyNo { get; set; }

        /// <summary>
        /// -Đối với màn hình Phát hành hoá đơn điện tử: CMC xem xét lấy Số tiền phí bảo hiểm trước VAT bằng cách nào hoặc có thể tính bằng 
        /// T.toán quy VNĐ – Thuế quy VNĐ
        /// -Đối với màn hình Phát hành hóa đơn nhà đồng: CMC xem xét lấy Số tiền phí bảo hiểm trước VAT bằng
        /// cách nào hoặc có thể tính bằng Tiền quy VNĐ – Thuế quy VNĐ
        /// -Đối với màn hình Thanh toán đồng bảo hiểm: CMC xem xét lấy Số tiền phí bảo hiểm trước VAT bằng cách nào hoặc có thể tính bằng Tiền – Thuế.
        /// Trong trường hợp Tiền và Thuế tính bằng ngoại tệ thì phải quy đổi về VNĐ bằng tỷ giá tương ứng lấy từ Hệ thống
        /// =>Ngân hàng và tiền tệ=>Tỷ giá thực tế
        /// </summary>
        public int Fee { get; set; }

        /// <summary>
        /// Dựa vào thông tin của hợp đồng để lấy thuế suất VAT theo bảng Hệ thống=>Mã nghiệp vụ
        /// =>Mã nghiệp vụ=>Mã nghiệp vụ bộ tài chính
        /// </summary>
        public int VATRate { get; set; }

        /// <summary>
        /// -Đối với màn hình Phát hành hoá đơn điện tử: Thuế quy VNĐ
        /// -Đối với màn hình Phát hành hóa đơn nhà đồng: Thuế quy VNĐ
        /// -Đối với màn hình Thanh toán đồng bảo hiểm: 
        /// Thuế.Trong trường hợp Thuế tính bằng ngoại tệ thì phải quy đổi về VNĐ bằng tỷ giá tương ứng lấy từ Hệ thống
        /// =>Ngân hàng và tiền tệ=>Tỷ giá thực tế
        /// </summary>
        public int VAT { get; set; }

        /// <summary>
        /// Trường ForeignCurrency, FeeInForeignCurrency và VATInForeignCurrency chỉ tồn tại khi hoá đơn chi trả bằng ngoại tệ
        /// -Xác định từ trường Mã n.tệ từ màn hình Phát hành hoá đơn điện tử
        /// -Xác định từ trường N.tệ từ màn hình Phát hành hóa đơn nhà đồng
        /// - Xác định từ trường N.tệ từ màn hình Thanh toán đồng bảo hiểm 
        /// </summary>
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// Trường ForeignCurrency, FeeInForeignCurrency và VATInForeignCurrency chỉ tồn tại khi hoá đơn chi trả bằng ngoại tệ
        /// -Đối với màn hình Phát hành hoá đơn điện tử: CMC xem xét lấy Số tiền phí bảo hiểm trước VAT 
        /// tính bằng ngoại tệ bằng cách nào hoặc có thể tính bằng Thanh toán – Thuế
        /// -Đối với màn hình Phát hành hóa đơn nhà đồng: CMC xem xét lấy Số tiền phí bảo hiểm trước VAT 
        /// tính bằng ngoại tệ bằng cách nào hoặc có thể tính bằng Tiền – Thuế
        /// -Đối với màn hình Thanh toán đồng bảo hiểm: CMC xem xét lấy Số tiền phí bảo hiểm trước VAT 
        /// tính bằng ngoại tệ bằng cách nào hoặc có thể tính bằng Tiền – Thuế
        /// </summary>
        public int FeeInForeignCurrency { get; set; }

        /// <summary>
        /// Trường ForeignCurrency, FeeInForeignCurrency và VATInForeignCurrency chỉ tồn tại khi hoá đơn chi trả bằng ngoại tệ
        /// -Đối với màn hình Phát hành hoá đơn điện tử: Thuế
        /// -Đối với màn hình Phát hành hóa đơn nhà đồng: Thuế
        /// -Đối với màn hình Thanh toán đồng bảo hiểm: Thuế
        /// </summary>
        public int VATInForeignCurrency { get; set; }
    }
}