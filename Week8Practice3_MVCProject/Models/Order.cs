using System.Security.AccessControl;

namespace Week8Practice3_MVCProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }       //sipariş edilen ürün miktarı
    }
}
