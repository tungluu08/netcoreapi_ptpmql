namespace BaiThucHanh.Models
{
    public class InvoiceModel
    {
        public int Quantity { get; set; } // Số lượng sản phẩm
        public decimal UnitPrice { get; set; } // Đơn giá
        public decimal TotalPrice { get; set; } // Tổng tiền

        public void CalculateTotal()
        {
            TotalPrice = Quantity * UnitPrice;
        }
    }
}
