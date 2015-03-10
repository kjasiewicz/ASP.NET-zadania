using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test.Entities.TPTInheritance
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Shop()
        {
            Products = new HashSet<Product>();
        }
    }
}
