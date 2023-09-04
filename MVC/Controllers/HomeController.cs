using DataAccess.Public.Interaces.Services;
using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Models;
using System.Diagnostics;

namespace PlatformDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;
        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var customersData = await _customerService.GetAllCustomer();
            return View(customersData);
        }

        [HttpGet]
        [Route("orders/{id}")]
        public async Task<IActionResult> Order(long id)
        {
            var customerData = await _customerService.GetByCustomerId(id);
            return View(customerData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}