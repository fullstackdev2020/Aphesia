using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphesia.API.Controllers
{
    public class CategoryController
    {
        private Aphesia.Provider.Controllers.CategoryController categoryController;

        public CategoryController()
        {
            categoryController = new Provider.Controllers.CategoryController();
        }

        public List<DTOs.Category> GetCategories()
        {
            var categories = categoryController.GetCategories();
            var categoryDTOs = new List<DTOs.Category>();
            foreach (var item in categories)
            {
                categoryDTOs.Add(new DTOs.Category()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Description = item.Description
                });
            }
            return categoryDTOs;
        }
    }
}
