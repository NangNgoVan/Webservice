using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebService.Models.invoices.NewReplaceAdjustInvoice
{
    public class CertificatesModel
    {
        /// <summary>
        /// ID của thông điệp
        /// </summary>
        public int MessageID { get; set; }

        /// <summary>
        /// Thời điểm gửi thông điệp
        /// </summary>
        public DateTime MessageTime { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu cho danh sách các giấy chứng nhận cần huỷ (Chỉ khi có giấy chứng nhận cần huỷ) 
        /// </summary>
        public List<RemovingCertificates> RemovingCertificates { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu cho danh sách các giấy chứng nhận cần tạo (Chỉ khi có giấy chứng nhận được tạo mới hoặc thay thê)
        /// </summary>
        public NewCertificates NewCertificates { get; set; }

        /// <summary>
        /// Mã người lập giấy chứng nhận trên core bảo hiểm
        /// </summary>
        public int CreatorCode { get; set; }

        /// <summary>
        /// Mã người duyệt trên core bảo hiểm
        /// </summary>
        public int ApproverCode { get; set; }
        //public int CreatorCode { get; set; }

        /// <summary>
        /// Mã phòng ban trên core bảo hiểm
        /// </summary>
        public int DepartmentCode { get; set; }

        /// <summary>
        /// Mã chi nhánh/tổng công ty trên core bảo hiểm
        /// </summary>
        public int BranchCode { get; set; }
    }

    public class RemovingCertificates
    {
        /// <summary>
        /// Số giấy chứng nhận cần huỷ.
        /// </summary>
        public List<string> CertificateNo { get; set; }
    }

    public class NewCertificates
    {
        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group Tag bắt đầu cho giấy chứng nhận cần tạo
        /// </summary>
        public List<Certificate> Certificate { get; set; }
    }

    public class Certificate
    {
        /// <summary>
        /// Số giấy chứng nhận bảo hiểm, lấy từ trường “Số GCN" 
        /// trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Số GCN” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string CertificateNo { get; set; }

        /// <summary>
        /// Tên chủ xe, lấy từ trường “Chủ xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Tên” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Địa chỉ chủ xe, lấy từ trường “Địa chỉ" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Địa chỉ” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string OwnerAddress { get; set; }

        /// <summary>
        /// Điện thoại liên lạc của khách hàng, lấy từ thông tin của khách hàng trong cửa sổ “Hệ thống mã khách hàng bảo hiểm” truy cập từ menu Hệ thống->Khách hàng và đối tác->Mã khách hàng
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Biển kiểm soát, lấy từ trường “Biển xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Biển xe” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string VehicleNo { get; set; }

        /// <summary>
        /// Người/Đơn vị thụ hưởng, lấy từ trường “Ng.hưởng" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Tên"trong tab “Người hưởng” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string Beneficiary { get; set; }

        /// <summary>
        /// Số khung, lấy từ trường “Số khung" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Số khung” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string ChassisNo { get; set; }

        /// <summary>
        /// Số máy, lấy từ trường “Số máy" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Số máy” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string EngineNo { get; set; }

        /// <summary>
        /// Xe ô tô chở người
        /// Xe ô tô vửa chở người vừa chở hàng
        /// Xe ô tô chở hàng(xe tải)
        /// Xe ô tô kinh doanh taxi
        /// Xe ô tô chuyên dùng(ben, cẩu, đông lạnh...)
        /// Xe đầu kéo, rơmooc
        /// </summary>
        public string VehicleType { get; set; }

        /// <summary>
        /// Hãng xe, lấy từ trường “Hãng xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Hãng xe” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// Ví dụ: TOYOTA
        /// </summary>
        public string Manufactory { get; set; }

        /// <summary>
        /// Hiệu xe, lấy từ trường “Hiệu xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Hiệu xe” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// Ví dụ: CAMRY
        /// </summary>
        public string ModelCode { get; set; }

        /// <summary>
        /// Năm sản xuất, lấy từ trường “Năm sx" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Năm sx” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int ProductYear { get; set; }

        /// <summary>
        /// Tải trọng xe, lấy từ trường “T.tải" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “T.tải” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int CartLoad { get; set; }

        /// <summary>
        /// Số chỗ ngồi, lấy từ trường “Số chỗ" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Số chỗ” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int SeatCount { get; set; }

        /// <summary>
        /// Mục đích sử dụng, lấy từ trường “M.đích SD" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Biển xe” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”. Có hai giá trị:
        /// Kinh doanh
        /// Không kinh doanh
        /// </summary>
        public string UsingPurpose { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Mức trách nhiệm tăng thêm về người bên thứ ba, lấy từ cột “Tiền" của mục bảo hiểm “TN với NTB về người” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public ThirdParties ThirdParties { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu thông tin Bảo hiểm trách nhiệm dân sự  đối với hàng hoá vận chuyển trên xe
        /// </summary>
        public Cargo Cargo { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu thông tin Bảo hiểm tai nạn lái phụ xe và người ngồi trên xe
        /// </summary>
        public Comprehensive Comprehensive { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu thông tin Bảo hiểm vật chất xe
        /// </summary>
        public Vehicle Vehicle { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group Tag bắt đầu cho các Điều  khoản bổ sung
        /// </summary>
        public Clauses Clauses { get; set; }

        /// <summary>
        /// Thời gian bắt đầu hiệu lực , lấy từ trường “Giờ bắt đầu có hiệu lực" và “Ngày bắt đầu có hiệu lực” (“Hiệu lực từ”) trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Giờ bắt đầu có hiệu lực" và “Ngày bắt đầu có hiệu lực” (“Hiệu lực từ”) trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string CoverFromTime { get; set; }

        /// <summary>
        /// Thời gian hết hiệu lực, lấy từ trường “Giờ hết hiệu lực" và “Ngày hết hiệu lực” (“Đến”) trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Giờ hết hiệu lực" và “Ngày hết hiệu lực” (“Đến”) trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string CoverToTime { get; set; }

        /// <summary>
        /// Tổng Phí bảo hiểm (Có VAT), lấy từ trường “Tổng phí” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Ttoán” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string TotalFee { get; set; }

        /// <summary>
        /// Ngày thanh toán phí, lấy thông tin từ tab “Kỳ thanh toán" trong màn hình “Hợp đồng bảo hiểm xe cơ giới” hoặc từ tab “Kỳ thanh toán” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”.
        /// -Trường hợp chỉ có một kỳ thanh toán thì lấy ngày công nợ khách hàng trên phần mềm trong(trường hợp thanh toán đủ phí)
        /// - Trường hợp nhiều kỳ thanh toán thì không lấy giá trị nào cả
        /// </summary>
        public string PaidDate { get; set; }

        /// <summary>
        /// Họ và tên Người cấp
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Kiểu khai thác, lấy từ trường “Khai thác" và trả về các giá trị tương ứng sau:
        /// T-Tự: Cán bộ kinh doanh
        /// D-Đại lý: Đại lý
        /// M-Môi giới: Hình thức khác
        /// N-Ngân hàng: Hình thức khác
        /// </summary>
        public string SellerType { get; set; }

        /// <summary>
        /// Mã của người lập giấy chứng nhận
        /// </summary>
        public string CreatorCode { get; set; }

        /// <summary>
        /// Mã chi nhánh của giấy chứng nhận
        /// </summary>
        public string BranchCode { get; set; }

        /// <summary>
        /// Mã của người duyệt giấy chứng nhận
        /// </summary>
        public string ApproverCode { get; set; }

        /// <summary>
        /// Số giấy chứng nhận bị thay thế. Nếu có trường này thì giấy chứng nhận mới sẽ thay thế cho giấy chứng nhận cũ với số giấy chứng nhận bị thay thế này
        /// </summary>
        public string ReplacedCertificateNo { get; set; }

    }

    public class ThirdParties
    {
        /// <summary>
        /// Mức trách nhiệm tăng thêm về người bên
        ///thứ ba, lấy từ cột “Tiền&quot; của mục bảo hiểm
        ///“TN với NTB về người” loại bảo hiểm “Tự
        ///    nguyện” trong bảng điều khoản của tab
        ///“Điều khoản chính&quot; trong màn hình “GCN
        ///    xe theo hợp đồng” hoặc trong bảng điều
        ///khoản của tab “Điều khoản chính&quot; trong
        ///    Trang số: 71/64
        ///màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int ThirdPartyLiabilityAmount { get; set; }

        /// <summary>
        /// Mức trách nhiệm tăng thêm về người hành khách, lấy từ cột “Tiền" của mục bảo hiểm “TN với hành khách” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int PassengerLiabilityAmount { get; set; }

        /// <summary>
        /// Mức trách nhiệm tăng thêm về tài sản, lấy từ cột “Tiền" của mục bảo hiểm “TN với NTB về tài sản” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int PropertyLiabilityAmount { get; set; }

        /// <summary>
        /// Giới hạn trách nhiệm tối đa, lấy từ trường “G.han t.nhiệm NTB mỗi vụ" mới thêm vào trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “G.han t.nhiệm NTB mỗi vụ" mới thêm vào trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int LiabilityRestrictionAmount { get; set; }

        /// <summary>
        /// Phí bảo hiểm (Có VAT), bẳng tổng mức phí (Có VAT) của các mức phí lấy từ cột “Phí" của mục bảo hiểm “TN với NTB về người”, mục bảo hiểm “TN với hành khách”, mục bảo hiểm “TN với NTB về tài sản”,  loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int Fee { get; set; }
    }

    public class Cargo
    {
        /// <summary>
        /// Tải trọng xe, lấy từ trường “T.tải" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “T.tải” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int CardLoad { get; set; }

        /// <summary>
        /// Mức trách nhiệm/tấn đối với hàng hoá vận chuyển trên xe, lấy từ cột “Tiền" của mục bảo hiểm “TN với hàng hoá” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int LiabilityAmount { get; set; }

        /// <summary>
        /// Mức khấu trừ bồi thường, lấy từ trường “Mức tiền miễn thường" của nghiệp vụ “TNDS chủ xe đối với hàng hoá vận chuyển trên xe” trong tab “Điều khoản bổ sung” trong màn hình “GCN xe theo hợp đồng” hoặc trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int DeductibleAmount { get; set; }

        /// <summary>
        /// Phí bảo hiểm (Có VAT), bẳng tổng mức phí (Có VAT) của các mức phí lấy từ cột “Phí" của mục bảo hiểm “TN với hàng hoá”, loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới 
        /// </summary>
        public int Fee { get; set; }
    }

    public class Comprehensive
    {
        /// <summary>
        /// Mức trách nhiệm lái, phụ xe, lấy từ cột “Tiền" của mục bảo hiểm “TN với người ngồi trên xe” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int DriverLiabilityAmount { get; set; }

        /// <summary>
        /// Số người lái, phụ xe, lấy từ trường “Số lái,phụ" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Số lái,phụ” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int DriverCount { get; set; }

        /// <summary>
        /// Mức trách nhiệm người ngồi trên xe, lấy từ cột “Tiền" của mục bảo hiểm “TN với người ngồi trên xe” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int PersonInVehicleLiabilityAmount { get; set; }

        /// <summary>
        /// Số người lái, phụ xe, lấy từ trường “Số người BH" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Số người BH” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int PersonInVehicleCount { get; set; }

        /// <summary>
        /// Phí bảo hiểm (Có VAT), bẳng tổng mức phí (Có VAT) của các mức phí lấy từ cột “Phí" của mục bảo hiểm “TN với người ngồi trên xe”, loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int Fee { get; set; }
    }

    public class Vehicle
    {
        /// <summary>
        /// Yêu cầu bảo hiểm, lấy từ trường “Chọn BH" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Chọn BH” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// Có hai giá trị:
        /// Toàn bộ
        /// Thân vỏ
        /// Hiện tai MIC chỉ có một loại bảo hiểm là Toàn bộ
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Giá trị xe, lấy từ trường “G.trị xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Giá k.báo” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string VehicleValue { get; set; }

        /// <summary>
        /// Số tiền bảo hiểm theo yêu  cầu, lấy từ cột “Tiền" của mục bảo hiểm “TN với vật chất xe” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string InsuranceValue { get; set; }

        /// <summary>
        /// Mức miền bồi thường, lấy từ trường “Mức tiền miễn thường" của nghiệp vụ “Bảo hiểm thiệt hại vật chất xe” trong tab “Điều khoản bổ sung” trong màn hình “GCN xe theo hợp đồng” hoặc trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string ExcessAmount { get; set; }

        /// <summary>
        /// Có khấu trừ hay không, lấy từ trường “K.trừ"của nghiệp vụ “Bảo hiểm thiệt hại vật chất xe” trong tab “Điều khoản bổ sung” trong màn hình “GCN xe theo hợp đồng” hoặc trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string Deductive { get; set; }

        /// <summary>
        /// Phí bảo hiểm (Có VAT), bẳng tổng mức phí (Có VAT) của các mức phí lấy từ cột “Phí" của mục bảo hiểm “TN với vật chất xe”, loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string Fee { get; set; }
    }

    public class Clauses
    {
        /// <summary>
        /// Danh sách các mã điều khoản bổ sung, trong trường “Số BS” của tab “Điều khoản bổ sung" trong màn hình “GCN xe theo hợp đồng” hoặc tab “Điều khoản bổ sung” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string ClauseCode { get; set; }
    }
}