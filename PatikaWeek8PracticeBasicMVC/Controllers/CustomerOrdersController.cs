using Microsoft.AspNetCore.Mvc;
using PatikaWeek8PracticeBasicMVC.Models;

namespace PatikaWeek8PracticeBasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customerOrderViewModel = new CustomerOrderViewModel(); // View Model oluşturuluyor.

            var customer = new Customer()
            {
                Id = 1,
                FirstName = "Bilal",
                LastName = "Bilin",
                Email = "bb@gmail.com"
            };
            
            customerOrderViewModel.customer = customer;

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Elma", Price = 26.00m, Quantity = 1000},
                new Order { Id = 2, ProductName = "Armut", Price = 20.00m, Quantity = 5000},
                new Order { Id = 3, ProductName = "Şeftali", Price = 30.00m, Quantity = 2500},
                new Order { Id = 4, ProductName = "Çilek", Price = 10.00m, Quantity = 12000},
                new Order { Id = 5, ProductName = "Karpuz", Price = 40.00m, Quantity = 2000},
                new Order { Id = 6, ProductName = "Kavun", Price = 50.00m, Quantity = 1500},

            };

            customerOrderViewModel.orders = orders;

            return View(customerOrderViewModel); // View Model gönderiliyor.
        }
    }
}
