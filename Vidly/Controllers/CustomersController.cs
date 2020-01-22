using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        CustomerViewModel customerViewModel = new CustomerViewModel
        {
            Customers = new List<Customer> {
                    new Customer {ID = 1, Name = "John Smith"},
                    new Customer {ID = 2, Name = "Mary Williams"}
                }
        };
        // GET: Customers
        public ActionResult Index()
        {
            return View(customerViewModel);
        }

        // GET: Customers/Details/1

        public ActionResult Details(int id)
        {
            var c = customerViewModel.Customers.FirstOrDefault(customer => customer.ID == id);
            if (c != null)
                return View(c);
            else
                return HttpNotFound("Customer not found");
        }
    }
}