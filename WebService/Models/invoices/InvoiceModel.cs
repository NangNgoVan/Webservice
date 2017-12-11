using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebService.Models.customers;
using WebService.Models.Organization;

namespace WebService.Models.invoices
{
    public class InvoiceModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Id của giao dịch (chỉ có khi sử dụng API tích hợp tạo hóa đơn)")]
        public Guid IdTransaction { get; set; }

        [Display(Name = "Đã in chuyển đổi")]
        public bool IsPrinted { get; set; }

        [Display(Name = "Ngày in chuyển đổi")]
        public DateTime? PrintDate { get; set; }

        [Display(Name = "Họ tên người in chuyển đổi")]
        public string FullNamePrinter { get; set; }

        [Display(Name = "Tên đăng nhập người in chuyển đổi")]
        public string UserNamePrinter { get; set; }
        //Invoice Infor

        [Display(Name = "Mã hóa đơn")]
        public string Code { get; set; } //MST|TemplateNo|SerialNo|InvoiceNo

        [Display(Name = "Mẫu số")]
        public string TemplateNo { get; set; } //01GTKT0/008

        [Display(Name = "Ký hiệu")]
        public string SerialNo { get; set; } //PT/17E ky hieu

        [Display(Name = "Số hóa đơn")]
        public string InvoiceNo { get; set; } //0000001 (7 ky tu)

        [Display(Name = "Ghi chú")]
        public string Note { get; set; } //Ghi chu

        [Display(Name = "Số hợp đồng")]
        public string ContractNumber { get; set; }

        [Display(Name = "Ngày hóa đơn")]
        public DateTime InvoiceDate { get; set; }

        public DateTime MaxDate { get; set; }

        public DateTime MinDate { get; set; }

        [Display(Name = "Ngày hợp đồng")]
        public DateTime? ContractDate { get; set; }

        [Display(Name = "Người vận chuyển")]
        public string Transporter { get; set; }

        [Display(Name = "Phương tiện vận chuyển")]
        public string Transportation { get; set; }

        [Display(Name = "Lệnh điều động số")]
        public string DocumentNumber { get; set; }

        [Display(Name = "Người/đơn vị điều động")]
        public string DocumentCreator { get; set; }

        [Display(Name = "Nội dung điều động")]
        public string DocumentContent { get; set; }

        [Display(Name = "Nơi giao hàng")]
        public string PlaceOfDelivery { get; set; }

        [Display(Name = "Nơi nhận hàng")]
        public string PlaceOfReceipt { get; set; }

        [Display(Name = "Kho xuất")]
        public string ExportWarehouse { get; set; }

        [Display(Name = "Kho nhập")]
        public string EntryWarehouse { get; set; }

        [Display(Name = "Tổng tiền trước thuế")]
        public decimal TotalAmount { get; set; } //Tong tien truoc thue

        [Display(Name = "Giá trị thuế VAT")]
        public decimal VatAmount { get; set; } //Tien VAT

        [Display(Name = "Tiền tệ")]
        public string FromCurrency { get; set; } //Tien te

        [Display(Name = "Tiền tệ")]
        public string ToCurrency { get; set; }

        [Display(Name = "Tỷ giá")]
        public double ExchangeRate { get; set; } //Ty gia

        [Display(Name = "Phương thức thanh toán")]
        public string PaymentMethod { get; set; } //Phuong thuc thanh toan

        [Display(Name = "Tên Phương thức thanh toán")]
        public string PaymentMethodDisplay { get; set; }

        [Display(Name = "Ngày thanh toán")]
        public DateTime? PaymentDate { get; set; } //Ngay thanh toan

        [Display(Name = "Số tiền bằng chữ")]
        public string PaymentAmountWords { get; set; } //So tien bang chu

        [Display(Name = "Tổng tiền sau thuế")]
        public decimal PaymentAmount { get; set; } //Tong tien phai tra


        [Display(Name = "Ngày ký")]
        public DateTime? SignDate { get; set; } //Ngay ky

        public string SignedBy { get; set; } //username

        public DateTime? ApprovalDate { get; set; }

        public string ApprovedBy { get; set; } //username
        
        public string InvoiceStatus { get; set; }

        [Display(Name = "Trạng thái hóa đơn")]
        public string InvoiceStatusDisplay { get; set; }

        public string SignStatus { get; set; } // trang thai ky /trang thai cap ma xac thuc

        [Display(Name = "Trạng thái ký")]
        public string SignStatusDisplay { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }


        public bool IsValidToSign { get; set; } // set false if create temp invoice 

        public string ErpId { get; set; }

        public string ErpInvoiceType { get; set; }

        public string ErpInvoiceTemplate { get; set; }

        public string ErpUser { get; set; } //Neu he thong ko co user ben ERP se mac dinh dang nhap bang tai khoan Guest (dc tao san)



        public Guid? IdReferenceInvoice { get; set; }

        //Trả thêm dữ liệu hóa đơn gốc nếu là hóa đơn điều chỉnh, thay thế
        // gồm có Mã số thuế|Mẫu số|Ký hiệu|Số hóa đơn. liên quan

        public string ReferenceInvoiceTaxCode { get; set; }

        public string ReferenceInvoiceNumber { get; set; }

        public string ReferenceInvoiceSerial { get; set; }

        public string ReferenceInvoiceInvoiceNo { get; set; }

        public string ReferenceInvoiceInvoiceDate { get; set; }

        public int? IdInvoiceTemplate { get; set; }

        public int? IdInvoiceType { get; set; }

        [Display(Name = "Mã loại hóa đơn")]
        public string InvoiceTypeCode { get; set; }

        [Display(Name = "Tên loại hóa đơn")]
        public string InvoiceTypeName { get; set; }


        public Guid IdAccount { get; set; }

        [Display(Name = "Tài khoản người tạo")]
        public string UserNameCreator { get; set; }

        [Display(Name = "Họ tên người tạo")]
        public string FullNameCreator { get; set; }

        public Guid? IdCustomer { get; set; }

        [Display(Name = "Email người mua")]
        public string EmailCustomer { get; set; }

        [Display(Name = "Họ tên người mua")]
        public string FullNameCustomer { get; set; }

        [Display(Name = "Số điện thoại người mua")]
        public string PhoneCustomer { get; set; }


        [Display(Name = "Ký hiệu tăng/giảm")]
        public string Operator { get; set; } //Tăng (+) hoặc giảm (-)

        [Display(Name = "Tổng tiền trước thuế sau điều chỉnh")]
        public decimal TotalAmountAfterAdjustment { get; set; } //Tổng tiền trước thuế sau điều chỉnh

        [Display(Name = "Giá trị VAT sau điều chỉnh")]
        public decimal VatAmountAfterAdjustment { get; set; } //Tiền VAT sau điều chỉnh

        [Display(Name = "Tổng tiền sau thuế sau điều chỉnh")]
        public decimal PaymentAmountAfterAdjustment { get; set; } //Tiền thanh toán sau điều chỉnh

        /// <summary>
        /// qrcode byte
        /// </summary>
        public byte[] QrCode { get; set; }

        public string Url { get; set; }

        public CustomerModel Customer { get; set; }

        public Guid IdCompany { get; set; }

        public OrganizationModel Organization { get; set; }

        [Display(Name = "Mã số thuế công ty bên bán")]
        public string CodeCompany { get; set; }

        public InvoiceSignedModel InvoiceSigned { get; set; }

        public List<InvoiceDetailModel> InvoiceDetails { get; set; }
    }
}
