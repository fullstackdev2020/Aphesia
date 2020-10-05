using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphesia.EF.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
