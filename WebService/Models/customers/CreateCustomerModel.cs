using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebService.Models.customers
{
    public class CreateCustomerModel
    {
        public Guid? Id { get; set; } = Guid.Empty;
        //[Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string Address { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Mã khách hàng không được để trống!")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [RegularExpression(@"^[a-zA-Z0-9|-|_]+$", ErrorMessage = "Mã khách hàng viết không dấu, không chứa các ký tự đặc biệt")]
        public string CustomerCode { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string BankAccount { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string BankName { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string City { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string Country { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string District { get; set; }

        //[Email(ErrorMessage = "Định dạng email không đúng")]
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        public string Fax { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string FullName { get; set; }

        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string LegalName { get; set; }

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        public string Phone { get; set; }

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        public string TaxCode { get; set; }

        public int? IdGroupCustomer { get; set; }

        [JsonIgnore]
        public Guid? CreateBy { get; set; }
        
        [JsonIgnore]
        public Guid? Owner { get; set; }
    }
}
