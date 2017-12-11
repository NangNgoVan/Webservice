using System;
using System.ComponentModel.DataAnnotations;

namespace WebService.Models.invoices
{
    public class InvoiceDetailModel
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        [Display(Name = "Số tiền chiết khấu")]
        public decimal DiscountAmount { get; set; } //Chiet khau

        [Display(Name = "Phần trăm chiết khấu")]
        public decimal DiscountPercent { get; set; } //% Chiet khau

        public DateTime? LastUpdate { get; set; }

        [Display(Name = "Tổng tiền sau thuế")]
        public decimal PaymentAmount { get; set; } //Tong tien sau thue

        [Display(Name = "Mã hàng hóa")]
        public string ProductId { get; set; }

        [Display(Name = "Tên hàng hóa")]
        public string ProductName { get; set; }

        [Display(Name = "Mã Đơn vị tính")]
        public short? UnitId { get; set; }//Mã Đơn vị tính

        [Display(Name = "Tên Đơn vị tính")]
        public string UnitName { get; set; } //Đơn vị tính

        [Display(Name = "Đơn giá")]
        public decimal UnitPrice { get; set; } //Đơn giá

        [Display(Name = "Số lượng")]
        public double Quantity { get; set; }

        [Display(Name = "Tổng tiền trước thuế")]
        public decimal TotalAmount { get; set; } //Tong tien truoc thue

        [Display(Name = "Phần trăm thuế")]
        public int VatPercent { get; set; } //% VAT

        [Display(Name = "Số tiền thuế")]
        public decimal VatAmount { get; set; } //VAT



        [Display(Name = "Ký hiệu tăng/giảm")]
        public string Operator { get; set; } //Ky hieu + hoac - de xac dinh tang hay giam

        [Display(Name = "Tên hàng hóa điều chỉnh")]
        public string ProductNameAdjustment { get; set; } //Tên hàng hóa điều chỉnh

        [Display(Name = "Đơn vị tính điều chỉnh")]
        public string UnitNameAdjustment { get; set; } //Đơn vị tính điều chỉnh



        [Display(Name = "Số lượng điều chỉnh")]
        public double QuantityOfAdjustment { get; set; } // Số lượng điều chỉnh

        [Display(Name = "Số lượng sau điều chỉnh")]
        public double QuantityAfterAdjustment { get; set; } // Số lượng sau điều chỉnh



        [Display(Name = "Đơn giá điều chỉnh")]
        public decimal UnitPriceOfAdjustment { get; set; } //Đơn giá điều chỉnh

        [Display(Name = "Đơn giá sau điều chỉnh")]
        public decimal UnitPriceAfterAdjustment { get; set; } //Đơn giá sau điều chỉnh



        [Display(Name = "Tổng tiền điều chỉnh")]
        public decimal TotalAmountOfAdjustment { get; set; } //Tổng tiền điều chỉnh

        [Display(Name = "Tổng tiền sau điều chỉnh")]
        public decimal TotalAmountAfterAdjustment { get; set; } //Tổng tiền trước thuế sau điều chỉnh



        [Display(Name = "Số tiền thuế VAT điều chỉnh")]
        public decimal VatAmountOfAdjustment { get; set; } //Tiền VAT điều chỉnh

        [Display(Name = "Số tiền thuế VAT sau điều chỉnh")]
        public decimal VatAmountAfterAdjustment { get; set; } //Tiền VAT sau điều chỉnh



        [Display(Name = "Tổng tiền điều chỉnh")]
        public decimal PaymentAmountOfAdjustment { get; set; } //Tiền phải trả điều chỉnh

        [Display(Name = "Tổng tiền sau điều chỉnh")]
        public decimal PaymentAmountAfterAdjustment { get; set; } //Tiền phải trả sau điều chỉnh

        [Display(Name = "Ghi chú")]
        public string Note { get; set; }


        //FK
        public Guid IdInvoiceHeader { get; set; }
    }
}
