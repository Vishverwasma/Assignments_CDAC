using Antlr.Runtime.Misc;
using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers;
        List<Order> orders;
        public CustomerController()
        {
            customers = new List<Customer>()
            {
                new Customer(){CustomerId=1001 ,ContactName="Vishwas Verma", City="Durg"},
                new Customer(){CustomerId=1002 ,ContactName="Abhishekh Verma", City="Pune"},
                new Customer(){CustomerId=1003 ,ContactName="Abhijeet Verma", City="Bhilai"},
            };
            orders = new List<Order>()
            {
                new Order(){ OrderId=1 ,OrderDate=DateTime.Now,Quantity=100 ,CustomerId=1002 },
                new Order(){ OrderId=2 ,OrderDate=DateTime.Now,Quantity=150 ,CustomerId=1003 },
                new Order(){ OrderId=3 ,OrderDate=DateTime.Now,Quantity=200 ,CustomerId=1001 },
            };
        }

        // GET: Customer
        public ActionResult Index()
        {
           if (DateTime.Now.Month<6)
                return View("List");
            else
                return View();
        }
        public ActionResult List()
        {
            ViewBag.PageTitle = "Welcome To Vishwas S Page";
            ViewBag.PageSubTitle = "Custommers of  Synechron Pvt. LTD. From Globe!";
           // ViewBag.Orders = orders;
            ViewData["PageTitle"] = "Welcome To Infoway Technologies";
            ViewData["PageSubTitle"] = "Customers Of Synechron pvt. ltd. From View Data";
            ViewData["Orders"] = orders; 
            return View(customers);
        }
        public ActionResult One()
        {
            ViewBag.pageTitle = "Page - 1 From ViewBag";
            ViewData["PageTitle"] = "Page - 1 From ViewData";
            TempData["PageTitle"] = "Page - 1 From TempData";
            return RedirectToAction("Two");
         }
        public ActionResult Two()
        {
            return View();
        }
    }
}