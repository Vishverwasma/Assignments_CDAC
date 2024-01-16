using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Synechron.EventsProtal.Dal;
using Synechron.EventsProtal.Models;


namespace Synechron.EventsProtal.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeesDal _employeesDal;
        public EmployeesController(EmployeesDal dal)
        {
            _employeesDal = dal;
        }
        // GET: Employees
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Welcome To EmployeeController Index Method ";
            ViewBag.PageSubTitle = "Welcome To Synechron  Employees List : Core Devolopment Team Of India!";
            return View(_employeesDal.GetAllEmployees());
        }
        public ActionResult Details(int id) 
        {
            ViewBag.PageTitle = "Welcomme To Synechron Employees List";
            ViewBag.PageSubTitle = "Core Devolopment Team Of India";
            return View(_employeesDal.GetEmployeeDetails(id));
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Avatar = "~/Images/noimage.png";
                int result = _employeesDal.InsertEmployees(employee);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}