using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphesia.EF.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Descrption { get; set; }
        public string ImagePath { get; set; }
        public string AudioPath { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
    }
}
