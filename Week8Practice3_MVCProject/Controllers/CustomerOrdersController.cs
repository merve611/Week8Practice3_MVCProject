using Microsoft.AspNetCore.Mvc;
using Week8Practice3_MVCProject.Models;

namespace Week8Practice3_MVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            //customer nesnesi oluşturuldu

            var customer = new Customer
            {
                Id = 1,
                FirstName = "Merve",
                LastName = "Çakıroğlu",
                Email = "mrveeckrrr@hotmail.com"
            };

            //Order nesneleri oluşturuldu



            var orders = new List<Order>() 
            {
                new Order { Id = 1,ProductName = "Telefon",Price = 20000, Quantity = 10},
                new Order { Id = 2,ProductName = "Bilgisayar",Price = 50000, Quantity = 5}
            };




            //Bu nesneler ile bir viewModel oluştuurldu
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
