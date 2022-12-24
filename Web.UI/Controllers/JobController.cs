using Business.Concrete;
using DataAccess.EntityFramework;
using Entitiy.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Business.FluentValidation;

namespace Web.UI.Controllers
{
    public class JobController : Controller
    {
        private JobManager jobManager = new JobManager(new EfJobDAL());
        public IActionResult Index()
        {
            var values = jobManager.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            JobValidator validator = new JobValidator();
            ValidationResult result = validator.Validate(job);
            if (result.IsValid)
            {
                jobManager.TInsert(job);
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

        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.TGetById(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Updatejob(int id)
        {
            var value = jobManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            jobManager.TUpdate(job);
            return RedirectToAction("Index");
        }
    }
}
