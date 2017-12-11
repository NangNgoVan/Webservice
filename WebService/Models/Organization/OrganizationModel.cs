using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebService.Models.Organization
{
    public class OrganizationModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự")]
        [Display(Name = "Địa chỉ người bán")]
        public string Address { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Tài khoản ngân hàng người bán")]
        public string BankAccount { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Chi nhánh ngân hàng người bán")]
        public string BankName { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Thành phố người bán")]
        public string City { get; set; }

        [Display(Name = "Mã người bán")]
        public Guid Code { get; set; }//ví dụ Company001 mã tự sinh

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Quốc tịch người bán")]
        public string Country { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Quận/huyện người bán")]
        public string District { get; set; }

        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Email sai định dạng vd: vninvoice@gmail.com | vninvoice@vninvoice.com | a@b.cc")]
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Email người bán")]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [Display(Name = "Số fax người bán")]
        public string Fax { get; set; }

        [Required(ErrorMessage = "Tên không được để trống!")]
        [StringLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Họ tên người bán")]
        public string FullName { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa 500 ký tự")]
        [Display(Name = "Họ tên người bán tiếng anh")]
        public string FullNameEnglish { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 50 ký tự")]
        [Display(Name = "Pháp nhân người bán")]
        public string LegalName { get; set; }

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [Display(Name = "Số điện thoại người bán")]
        public string Phone { get; set; }

        [Display(Name = "Mã số thuế người bán")]
        public string TaxCode { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [Display(Name = "Loại hình kinh doanh")]
        public string BusinessType { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn cơ quan thuế quản lý")]
        public int IdTaxDepartment { get; set; }

        [Required(ErrorMessage = "Ngày tài chính không được để trống!")]
        [DataType(DataType.Date)]
        public DateTime DayOfUse { get; set; } // Ngày bắt đầu sử dụng hóa đơn điện tử, căn cứ vào ngày này để làm báo cáo BC26

        [JsonIgnore]
        public Guid? CreateBy { get; set; }

        [JsonIgnore]
        public Guid? OrganizationCode { get; set; }

        [JsonIgnore]
        public string Owner { get; set; }
    }
}