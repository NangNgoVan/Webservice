using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebService.Models.invoices.NewReplaceAdjustInvoice
{
    public class ProcessCertificatesModel
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
        /// Số hợp đồng bảo hiểm liên kết với GCN
        /// </summary>
        public string PolicyNo { get; set; }

        /// <summary>
        /// Thao tác trên hợp đồng ở core bảo hiểm. Có các giá trị tương ứng sau:
        /// NewPolicy: Hợp đồng mới
        /// Endorsement: Sửa đổi bố sung
        /// Cancel: Huỷ hợp đồng
        /// Termination: Kết thúc hợp đồng
        /// CancelRestored: Phục hồi lại hợp đồng bị huỷ
        ///  TerminationRestored: Phục hồi lại hợp đồng bị kết thúc
        /// </summary>
        public string PolicyOperation { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu cho danh sách các giấy chứng nhận cần huỷ (Chỉ khi có giấy chứng nhận cần huỷ) 
        /// </summary>
        public RemovingCertificates RemovingCertificates { get; set; }

        [XmlElement(IsNullable = false)]
        /// <summary>
        /// Group tag bắt đầu cho danh sách các giấy chứng nhận cần tạo (Chỉ khi có giấy chứng nhận được tạo mới hoặc thay thê)
        /// </summary>
        public NewCertificates NewCertificates { get; set; }


        /// <summary>
        /// Mã khách hàng trên core bảo hiểm
        /// </summary>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Mã của người lập giấy chứng nhận
        /// </summary>
        public string CreatorCode { get; set; }

        /// <summary>
        /// Mã của người duyệt giấy chứng nhận
        /// </summary>
        public string ApproverCode { get; set; }

        /// <summary>
        /// Mã phòng ban trên core bảo hiểm
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Mã chi nhánh của giấy chứng nhận
        /// </summary>
        public string BranchCode { get; set; }
    }

    public class RemovingCertificates
    {
        /// <summary>
        /// Số giấy chứng nhận cần huỷ.
        /// </summary>
        [XmlElement(IsNullable = false)]
        public string CertificateSerie { get; set; }
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
        /// Số serie của giấy chứng nhận bảo hiểm cấp 
        /// </summary>
        public string CertificateSerie { get; set; }

        /// <summary>
        /// Tên chủ xe, lấy từ trường “Chủ xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Tên” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Mã số thuế (đối với khách hàng doanh nghiệp), lấy từ thông tin của khách hàng trong cửa sổ “Hệ thống mã khách hàng bảo hiểm” truy cập từ menu Hệ thống->Khách hàng và đối tác->Mã khách hàng
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Số Chứng minh thư nhân dân của chủ xe (đối với khách hàng cá nhân), lấy từ thông tin của khách hàng trong cửa sổ “Hệ thống mã khách hàng bảo hiểm” truy cập từ menu Hệ thống->Khách hàng và đối tác->Mã khách hàng
        /// </summary>
        public string IDNumber { get; set; }

        /// <summary>
        /// Địa chỉ chủ xe, lấy từ trường “Địa chỉ" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Địa chỉ” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string OwnerAddress { get; set; }

        /// <summary>
        /// Điện thoại liên lạc của khách hàng, lấy từ thông tin của khách hàng trong cửa sổ “Hệ thống mã khách hàng bảo hiểm” truy cập từ menu Hệ thống->Khách hàng và đối tác->Mã khách hàng
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email của khách hàng, lấy từ thông tin của khách hàng trong cửa sổ “Hệ thống mã khách hàng bảo hiểm” truy cập từ menu Hệ thống->Khách hàng và đối tác->Mã khách hàng
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Biển kiểm soát, lấy từ trường “Biển xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Biển xe” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string VehicleNo { get; set; }

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
        /// Giá trị xe, lấy từ trường “G.trị xe" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Giá k.báo” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public int VehicleValue { get; set; }

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

        /// <summary>
        /// Tổng Phí bảo hiểm (Có VAT), lấy từ trường “Tổng phí” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Ttoán” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string TotalFee { get; set; }

        /// <summary>
        /// Tổng tất cả thuế VAT của tất cả các nghiệp vụ bảo hiểm
        /// </summary>
        public string VAT { get; set; }

        /// <summary>
        /// Tổng Phí bảo hiểm (Có VAT), lấy từ trường “Tổng phí” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Ttoán” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string TotalFeeWithVAT { get; set; }

        /// <summary>
        /// Thời gian bắt đầu hiệu lực , lấy từ trường “Giờ bắt đầu có hiệu lực" và “Ngày bắt đầu có hiệu lực” (“Hiệu lực từ”) trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Giờ bắt đầu có hiệu lực" và “Ngày bắt đầu có hiệu lực” (“Hiệu lực từ”) trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public DateTime CoverFromTime { get; set; }

        /// <summary>
        /// Thời gian hết hiệu lực, lấy từ trường “Giờ hết hiệu lực" và “Ngày hết hiệu lực” (“Đến”) trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Giờ hết hiệu lực" và “Ngày hết hiệu lực” (“Đến”) trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public DateTime CoverToTime { get; set; }

        /// <summary>
        /// Người/Đơn vị thụ hưởng bảo hiêm, lấy từ trường “Ng.hưởng" trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Tên"trong tab “Người hưởng” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string Beneficiary { get; set; }

        /// <summary>
        ///Thời điểm nộp phí, lấy từ trường “Thời điểm nôp phí” mới thêm vào trong trong màn hình “GCN xe theo hợp đồng” hoặc từ trường “Thời điểm nôp phí” mới thêm trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”.
        ///Lưu ý: Nếu có trường thời điểm nộp phí thì sẽ không có trường thời hạn thanh toán phí và ngược lại.Trên hệ thống ấn chỉ điện tử, nếu có trường thời điểm nộp phí thì trong bản thể hiện của ấn chỉ điện tử sẽ hiển thị thời điểm nộp phí, nếu có trường thời hạn nộp phí sẽ hiển thị thời hạn nộp phí
        /// </summary>
        public string PaidDate { get; set; }

        /// <summary>
        /// Thời hạn thanh toán phí, lấy thông tin từ tab “Kỳ thanh toán" trong màn hình “Hợp đồng bảo hiểm xe cơ giới” hoặc từ tab “Kỳ thanh toán” trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”.
        /// -Trường hợp chỉ có một kỳ thanh toán thì lấy ngày công nợ khách hàng trên phần mềm(trường hợp thanh toán đủ phí)
        /// - Trường hợp nhiều kỳ thanh toán thì không lấy giá trị nào cả
        /// </summary>
        public string PaymentDueDate { get; set; }

        /// <summary>
        /// Số serie của giấy chứng nhận bị thay thế. Nếu có trường này thì giấy chứng nhận mới sẽ thay thế cho giấy chứng nhận cũ với số giấy chứng nhận bị thay thế này
        /// </summary>
        public string ReplacedCertificateSerie { get; set; }
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

        [XmlElement(IsNullable = false)]
        public Clauses Clauses { get; set; }

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
        /// Số tiền bảo hiểm theo yêu  cầu, lấy từ cột “Tiền" của mục bảo hiểm “TN với vật chất xe” loại bảo hiểm “Tự nguyện” trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN xe theo hợp đồng” hoặc trong bảng điều khoản của tab “Điều khoản chính" trong màn hình “GCN bảo hiểm xe cơ giới bán lẻ”
        /// </summary>
        public string InsuranceValue { get; set; }

        [XmlElement(IsNullable = false)]
        public Clauses Clauses { get; set; }

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
        public List<string> ClauseCode { get; set; }
    }
}