using Microsoft.AspNetCore.Mvc;
using RepositoryExample.Business.Services;
using RepositoryExample.Business.Services.IServices;
using RepositoryExample.Data.UnitOfWork;
using RepositoryExample.Models.Entities;

namespace RepostioryExample.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
