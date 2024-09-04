using Microsoft.VisualBasic;

namespace Week8Practice3_MVCProject.Models
{
    public class CustomerOrderViewModel
    {
        //model verilerini ve view'da göstermek için gerekli ek bilgiler
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }

    }
}
