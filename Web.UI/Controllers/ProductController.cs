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
    public class ProductController : Controller
    {
        private ProductManager productManager = new ProductManager(new EfProductDAL());
        private CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        public IActionResult Index()
        {
            var valus = productManager.GetProductsListWithCategory();
            return View(valus);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in categoryManager.TGetlist()
                select new SelectListItem

                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator validator = new ProductValidator();
            ValidationResult result = validator.Validate(product);
            if (result.IsValid)
            {
                productManager.TInsert(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();

        }

        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            List<SelectListItem> values = (from x in categoryManager.TGetlist()
                select new SelectListItem

                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.v = values;
            var value = productManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            
            productManager.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}
