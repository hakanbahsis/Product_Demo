using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using Business.FluentValidation;
using DataAccess.EntityFramework;
using Entitiy.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.UI.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerManager customerManager = new CustomerManager(new EfCustomerDAL());
        JobManager jobManager = new JobManager(new EfJobDAL());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomersListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            
            List<SelectListItem> values = (from x in jobManager.TGetlist()
                select new SelectListItem
                
                {
                    Text = x.Name,
                    Value = x.JobId.ToString()
                }).ToList();
            ViewBag.v=values;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validator = new CustomerValidator();
            ValidationResult result = validator.Validate(customer);
            if (result.IsValid)
            {
                customerManager.TInsert(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> values = (from x in jobManager.TGetlist()
                select new SelectListItem

                {
                    Text = x.Name,
                    Value = x.JobId.ToString()
                }).ToList();
            ViewBag.v = values;
            var value = customerManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            
            customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }
    }
}
