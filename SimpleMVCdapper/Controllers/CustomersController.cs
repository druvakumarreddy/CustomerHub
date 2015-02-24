using SimpleMVCdapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVCdapper.Services;
using Dapper;

namespace SimpleMVCdapper.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            CustomerService List = new CustomerService();
            return View(List.AllCustList().ToList());
        }

        [HttpGet][ActionName("AddCust")]
        public ActionResult AddCust_Get()
        {
            return View();
        }

        [HttpPost][ActionName("AddCust")]
        public ActionResult AddCust_Post(Customerinfo NewCust)
        {
            CustomerService New = new CustomerService();
            New.AddCust(NewCust);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCust(long id)
        {
            CustomerService edit = new CustomerService();

            Customerinfo info = edit.AllCustList().Single(cust => cust.ID == id);
            return View(info);

            //return View(edit.GetCust(id));
        }

        [HttpPost]
        public ActionResult UpdateCust(Customerinfo Update)
        {
            CustomerService edit = new CustomerService();
            edit.UpdateCust(Update);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            CustomerService details = new CustomerService();
            Customerinfo info = details.AllCustList().Single(cust => cust.ID == id);
            return View(info);
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            CustomerService delete = new CustomerService();
            Customerinfo info = delete.AllCustList().Single(cust => cust.ID == id);
            return View(info);
        }

        [HttpPost]
        public ActionResult Delete(Customerinfo delete)
        {
            CustomerService customerService = new CustomerService();
            customerService.Delete(delete);
            return RedirectToAction("Index");
        }
	}
}