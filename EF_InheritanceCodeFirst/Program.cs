using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_InheritanceCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                AppDomain.CurrentDomain.BaseDirectory);
            Database.SetInitializer(new Model1.InnitiallizerKasi());
            using(var db = new Model1())
            {
                Console.WriteLine(db.People.OfType<Student>().Count());
                Console.WriteLine(db.Courses.OfType<OnsiteCourse>().Count());
            }
        }
    }
}
