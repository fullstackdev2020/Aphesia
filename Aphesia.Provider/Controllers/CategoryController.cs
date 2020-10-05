using Aphesia.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphesia.Provider.Controllers
{
    public class CategoryController
    {
        public List<Category> GetCategories()
        {
            var ctx = new Aphesia.EF.DbContext.AphesiaContext();
            return ctx.Categories.ToList();
        }
    }
}
