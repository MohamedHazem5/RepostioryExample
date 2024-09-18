using RepositoryExample.Data.UnitOfWork;
using RepositoryExample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample.Business.Services
{
    public class CategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _unitOfWork.Categories.GetAll();
        }

        public void AddCategory(Category category)
        {
            _unitOfWork.Categories.Add(category);
            _unitOfWork.save();
        }
    }
}
