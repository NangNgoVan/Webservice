using System.ComponentModel.DataAnnotations;

namespace WebService.Models.invoices
{
    public class CreateInvoiceDetailModel
    {
        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Chiet khau phải lớn hơn hoặc bằng 0")]
        public decimal DiscountAmount { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "% Chiet khau phải lớn hơn hoặc bằng 0")]
        public decimal DiscountPercent { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tong tien sau thue phải lớn hơn hoặc bằng 0")]
        public decimal PaymentAmount { get; set; }

        [MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        public string ProductId { get; set; }

        [MaxLength(500, ErrorMessage = "Tối đa 500 ký tự")]
        public string ProductName { get; set; }

        public string UnitId { get; set; }//Mã Đơn vị tính

        public string UnitName { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn hoặc bằng 0")]
        public decimal UnitPrice { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 0")]
        public double Quantity { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tong tien truoc thue phải lớn hơn hoặc bằng 0")]
        public decimal TotalAmount { get; set; }

        public int VatPercent { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "VAT phải lớn hơn hoặc bằng 0")]
        public decimal VatAmount { get; set; }

        [StringLength(1, ErrorMessage = "Độ dài cho phép 1 ký tự")]
        public string Operator { get; set; }

        public string ProductNameAdjustment { get; set; }

        public string UnitNameAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Số lượng điều chỉnh phải lớn hơn hoặc bằng 0")]
        public double QuantityOfAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Số lượng sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public double QuantityAfterAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Đơn giá điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal UnitPriceOfAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Đơn giá sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal UnitPriceAfterAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tổng tiền điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal TotalAmountOfAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tổng tiền trước thuế sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal TotalAmountAfterAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tiền VAT điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal VatAmountOfAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tiền VAT sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal VatAmountAfterAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tiền phải trả điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal PaymentAmountOfAdjustment { get; set; }

        [Range(-double.MaxValue, double.MaxValue, ErrorMessage = "Tiền phải trả sau điều chỉnh phải lớn hơn hoặc bằng 0")]
        public decimal PaymentAmountAfterAdjustment { get; set; }

        [MaxLength(2000, ErrorMessage = "Nội dung tối đa 2000 ký tự")]
        public string Note { get; set; }
    }
}
