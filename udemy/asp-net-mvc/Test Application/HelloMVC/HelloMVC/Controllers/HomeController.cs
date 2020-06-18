using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.MySuperProperty = "This is my first app!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewCustomer(Customer postedCustomer)
        {
            Customer customer = new Customer();

            customer.Id = Guid.NewGuid().ToString();
            customer.Name = postedCustomer.Name;
            customer.Telephone = postedCustomer.Telephone;

            return View(customer);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }

        public ActionResult CustomerList()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer() { Name="Fred", Telephone = "12354"});
            customers.Add(new Customer() { Name = "Sally", Telephone = "121111" });
            customers.Add(new Customer() { Name = "Henry", Telephone = "834957" });

            return View(customers);
        }
    }
}