using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebService.Models.customers;

namespace WebService.Models.invoices
{
    public class CreateInvoiceModel
    {
        public string IdIntegrate { get; set; } // dùng dồng bộ db trung gian

        public Guid? Owner { get; set; } // bỏ JsonIgnore dùng dồng bộ db trung gian

        public Guid? CreateBy { get; set; } // bỏ JsonIgnore dùng dồng bộ db trung gian

        public string UserNameCreator { get; set; }

        public string FullNameCreator { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InvoiceDate { get; set; }

        [MaxLength(500, ErrorMessage = "Tối đa 500 ký tự")]
        public string Note { get; set; } //Ghi chu

        public Guid? IdReferenceInvoice { get; set; }

        public string ReferenceInvoice { get; set; }

        [Required(ErrorMessage = "Mẫu hóa đơn không được để trống")]
        public int IdInvoiceTemplate { get; set; }

        [Required(ErrorMessage = "Loại hóa không được để trống")]
        public int IdInvoiceType { get; set; }

        //Money
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền trước thuế phải lớn hơn 0")]
        public decimal TotalAmount { get; set; } //Tong tien truoc thue

        public bool IsVatForInvoice { get; set; } //Thue tung san pham hay tong gia tri hoa don

        [Range(0, double.MaxValue, ErrorMessage = "Tiền thuế phải lớn hơn hoặc bằng 0")]
        public double VatPercent { get; set; } //% VAT

        [Range(0, double.MaxValue, ErrorMessage = "Tiền thuế phải lớn hơn hoặc bằng 0")]
        public decimal VatAmount { get; set; } //Tien VAT

        //Payments
        [MaxLength(10, ErrorMessage = "Tối đa 10 ký tự")]
        public string FromCurrency { get; set; } //Tien te

        [MaxLength(10, ErrorMessage = "Tối đa 10 ký tự")]
        public string ToCurrency { get; set; }
        
        public double ExchangeRate { get; set; } //Ty gia

        [Required(ErrorMessage = "Phuong thuc thanh toan không được để trống")]
        [MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        public string PaymentMethod { get; set; } //Phuong thuc thanh toan

        [Required(ErrorMessage = "Vui lòng nhập ngày thanh toán")]
        [DataType(DataType.Date)]
        public DateTime? PaymentDate { get; set; } //Ngay thanh toan

        [Required(ErrorMessage = "Số tiền thanh toán bằng chữ không được để trống!")]
        [MaxLength(1000, ErrorMessage = "Tối đa 1000 ký tự")]
        public string PaymentAmountWords { get; set; } //So tien bang chu

        [Required(ErrorMessage = "Số tiền thanh toán bằng số không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Tiền thanh toán phải lớn hơn hoặc bằng 0")]
        public decimal PaymentAmount { get; set; } //Tong tien phai tra

        [MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        public string ErpId { get; set; }

        [MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        public string ErpInvoiceType { get; set; } // thong tin invoice type gan zo idinvoicetype

        [MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        public string ErpInvoiceTemplate { get; set; }

        [MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        public string ErpUser { get; set; } //Neu he thong ko co user ben ERP se mac dinh dang nhap bang tai khoan Guest (dc tao san)

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        public string ContractNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ContractDate { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string Transporter { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string Transportation { get; set; }
        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        public string DocumentNumber { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string DocumentCreator { get; set; }
        [MaxLength(2000, ErrorMessage = "Tối đa 2000 ký tự")]
        public string DocumentContent { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string PlaceOfDelivery { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string PlaceOfReceipt { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string ExportWarehouse { get; set; }
        [MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        public string EntryWarehouse { get; set; }

        public string Operator { get; set; } //Tăng (+) hoặc giảm (-)
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền trước thuế sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal TotalAmountAfterAdjustment { get; set; } //Tổng tiền trước thuế sau điều chỉnh
        [Range(0, double.MaxValue, ErrorMessage = "Tiền VAT sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal VatAmountAfterAdjustment { get; set; } //Tiền VAT sau điều chỉnh
        [Range(0, double.MaxValue, ErrorMessage = "Tiền thanh toán sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal PaymentAmountAfterAdjustment { get; set; } //Tiền thanh toán sau điều chỉnh

        public CreateCustomerModel Customer { get; set; }

        public List<CreateInvoiceDetailModel> InvoiceDetails { get; set; }
        public List<CreateInvoiceExtraDetailModel> InvoiceExtraDetails { get; set; }
        public double DiscountPercent { get; set; }
        public decimal TotalDiscountAmount { get; set; }
    }
}
