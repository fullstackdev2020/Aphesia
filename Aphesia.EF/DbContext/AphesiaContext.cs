using Aphesia.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphesia.EF.DbContext
{
    public class AphesiaContext : System.Data.Entity.DbContext
    {
        public AphesiaContext() : base("name=AphesiaDb")
        {

        }

        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<Message> Messages { get; set; }
        public System.Data.Entity.DbSet<Settings> Settings { get; set; }
    }
}
