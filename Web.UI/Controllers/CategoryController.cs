using Business.Concrete;
using Business.FluentValidation;
using DataAccess.EntityFramework;
using Entitiy.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        public IActionResult Index()
        {
            var values = categoryManager.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator validator = new CategoryValidator();
            ValidationResult result = validator.Validate(category);
            if (result.IsValid)
            {
                categoryManager.TInsert(category);
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

        public IActionResult DeleteCategory(int id)
        {
            var value=categoryManager.TGetById(id);
            categoryManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value= categoryManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            categoryManager.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
