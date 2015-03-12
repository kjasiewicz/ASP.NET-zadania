using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_InheritanceDesigner
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db= new SchoolContext())
            {
                db.Courses.Add(new OnlineCourse
                {
                    Title = "sfjfdj",
                    URL="blabla",
                    DepartmentID=2                    
                });
                db.SaveChanges();
                var k =db.Courses.OfType<OnlineCourse>().Count();
                Console.WriteLine(k);                
            }
        }
    }
}
