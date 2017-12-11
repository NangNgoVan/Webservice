using System;

namespace WebService.Entity
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal DiscountAmount { get; set; } //Chiet khau
        public decimal DiscountPercent { get; set; } //% Chiet khau
        public DateTime? LastUpdate { get; set; }
        public decimal PaymentAmount { get; set; } //Tong tien sau thue
        public Guid? IdProduct { get; set; }
        public string ProductCode { get; set; }//Mã sản phẩm
        public string ProductName { get; set; }//Mã Sản phẩm
        public short? IdUnit { get; set; }// Id bản ghi bảng Unit
        public string UnitName { get; set; } //Tên Đơn vị tính
        public decimal UnitPrice { get; set; } //Đơn giá
        public double Quantity { get; set; }
        public decimal TotalAmount { get; set; } //Tong tien truoc thue
        public int VatPercent { get; set; } //% VAT
        public decimal VatAmount { get; set; } //VAT

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

        public string Note { get; set; }

        //FK
        public Guid IdInvoiceHeader { get; set; }
        public virtual InvoiceHeader InvoiceHeader { get; set; }
    }
}

