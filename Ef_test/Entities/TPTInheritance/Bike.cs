using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test.Entities.TPTInheritance
{
    public enum eBikeType
    { 
        City,
        Cross,
        DownHill
    }
    [Table("Bikes")]
    public class Bike:Product
    {
        public eBikeType BikeType { get; set; }
    }
}
