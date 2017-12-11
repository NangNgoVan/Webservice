using System;
using System.Collections.Generic;

namespace WebService.Entity
{
    public class InvoiceHeader
    {
        public Guid Id { get; set; }
        public string Code { get; set; } //MST|TemplateNo|SerialNo|InvoiceNo
        public string TemplateNo { get; set; } //01GTKT0/008
        public string SerialNo { get; set; } //PT/17E ky hieu
        public string InvoiceNo { get; set; } //0000001 (7 ky tu)
        public string Note { get; set; } //Ghi chu
        public DateTime InvoiceDate { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public string Transporter { get; set; }
        public string Transportation { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentCreator { get; set; }
        public string DocumentContent { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string PlaceOfReceipt { get; set; }
        public string ExportWarehouse { get; set; }
        public string EntryWarehouse { get; set; }

        public decimal TotalAmount { get; set; } //Tong tien truoc thue

        public decimal VatAmount { get; set; } //Tien VAT


        public string FromCurrency { get; set; } //Tien te
        public string ToCurrency { get; set; }
        public double ExchangeRate { get; set; } //Ty gia

        public string PaymentMethod { get; set; } //Phuong thuc thanh toan
        public DateTime? PaymentDate { get; set; } //Ngay thanh toan
        public string PaymentAmountWords { get; set; } //So tien bang chu
        public decimal PaymentAmount { get; set; } //Tong tien phai tra
        public double Quantity { get; set; }

        /// <summary>
        /// % chiết khấu
        /// </summary>
        public double DiscountPercent { get; set; }

        /// <summary>
        /// Tổng Số tiền chiết khấu (Giá trị của $ chiết khấu)
        /// </summary>
        public decimal TotalDiscountAmount { get; set; }

        public string Operator { get; set; } //Ky hieu + hoac - de xac dinh tang hay giam
        public string ProductNameAdjustment { get; set; } //Tên hàng hóa điều chỉnh
        public string UnitNameAdjustment { get; set; } //Đơn vị tính điều chỉnh

        public double QuantityOfAdjustment { get; set; } // Số lượng điều chỉnh
        public double QuantityAfterAdjustment { get; set; } // Số lượng sau điều chỉnh

        public decimal UnitPriceOfAdjustment { get; set; } //Đơn giá điều chỉnh
        public decimal UnitPriceAfterAdjustment { get; set; } //Đơn giá sau điều chỉnh

        public decimal TotalAmountOfAdjustment { get; set; } //Tổng tiền điều chỉnh
        public decimal TotalAmountAfterAdjustment { get; set; } //Tổng tiền trước thuế sau điều chỉnh

        public decimal VatAmountOfAdjustment { get; set; } //Tiền VAT điều chỉnh
        public decimal VatAmountAfterAdjustment { get; set; } //Tiền VAT sau điều chỉnh

        public decimal PaymentAmountOfAdjustment { get; set; } //Tiền phải trả điều chỉnh
        public decimal PaymentAmountAfterAdjustment { get; set; } //Tiền phải trả sau điều chỉnh

        public DateTime? SignDate { get; set; } //Ngay ky
        public string SignedBy { get; set; } //username

        public DateTime? ApprovalDate { get; set; }
        public string ApprovedBy { get; set; } //username

        public string InvoiceStatus { get; set; }
        public string SignStatus { get; set; } // trang thai ky /trang thai cap ma xac thuc
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        
        public bool IsValidToSign { get; set; } // set false if create temp invoice 

        public Guid IdTransaction { get; set; } //Id Transaction, dùng làm 1 giao dịch duy nhất cho 1 hoặc nhiều hóa đơn
        public string IdInvoiceThirdParty { get; set; } //Id bản ghi hóa đơn bên thứ 3
        public string UserNameThirdParty { get; set; } //Tài khoản đăng nhập của bên thứ 3

        public string ErpId { get; set; }
        public string ErpInvoiceType { get; set; }
        public string ErpInvoiceTemplate { get; set; }
        public string ErpUser { get; set; } //Neu he thong ko co user ben ERP se mac dinh dang nhap bang tai khoan Guest (dc tao san)

        public Guid? IdReferenceInvoice { get; set; } //Id hóa đơn liên quan
        public string ReferenceInvoice { get; set; } //Mẫu số|Ký hiệu|Số hóa đơn liên quan


        public int? IdInvoiceTemplate { get; set; }
        public int? IdInvoiceType { get; set; }
        public string InvoiceTypeCode { get; set; }
        public string InvoiceTypeName { get; set; }

        public Guid IdAccount { get; set; }
        public string UserNameCreator { get; set; }
        public string FullNameCreator { get; set; }

        public string EmailCustomer { get; set; }
        public string FullNameCustomer { get; set; }
        public string PhoneCustomer { get; set; }

        public bool IsPrinted { get; set; } //Đã in bản chuyển đổi chưa
        public DateTime? PrintDate { get; set; } //Ngày in chuyển đổi
        public string FullNamePrinter { get; set; } //Họ tên người in chuyển đổi
        public string UserNamePrinter { get; set; } //Tài khoản đăng nhập người in chuyển đôi

        //FK
        public Guid IdOrganization { get; set; }
        //public virtual Organization Organization { get; set; }

        public Guid? IdCustomer { get; set; }
        //public virtual Customer Customer { get; set; }

        public virtual InvoiceSigned InvoiceSigned { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public virtual ICollection<InvoiceExtraDetail> InvoiceExtraDetails { get; set; }
    }
}
