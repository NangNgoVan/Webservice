using System;
using System.ComponentModel.DataAnnotations;

namespace WebService.Models.customers
{
    public class CustomerModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Địa chỉ người mua")]
        public string Address { get; set; }

        [Display(Name = "Tài khoản ngân hàng người mua")]
        public string BankAccount { get; set; }

        [Display(Name = "Chi nhánh ngân hàng người mua")]
        public string BankName { get; set; }

        [Display(Name = "Thành phố người mua")]
        public string City { get; set; }

        [Display(Name = "Mã ẩn người mua")]
        public string Code { get; set; }

        [Display(Name = "Mã người mua")]
        public string CustomerCode { get; set; }

        [Display(Name = "Quốc tịch người mua")]
        public string Country { get; set; }

        [Display(Name = "Quận/huyện người mua")]
        public string District { get; set; }

        [Display(Name = "Email người mua")]
        public string Email { get; set; }

        [Display(Name = "Số fax người mua")]
        public string Fax { get; set; }

        [Display(Name = "Họ tên người mua")]
        public string FullName { get; set; }

        [Display(Name = "Pháp nhân người mua")]
        public string LegalName { get; set; }

        [Display(Name = "Số điện thoại người mua")]
        public string Phone { get; set; }

        [Display(Name = "Mã số thuế người mua")]
        public string TaxCode { get; set; } // mã số thuế

        public string Status { get; set; } //ActiveStatus

        public string StatusDisplay { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int? IdGroupCustomer { get; set; }
        
    }
}
