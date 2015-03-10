using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test.Entities.TPTInheritance
{
    [Table("Tires")]
    public class Tire:Product
    {
        public int Size { get; set; }
    }
}
