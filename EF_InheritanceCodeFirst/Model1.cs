namespace EF_InheritanceCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SchoolContext")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public class InnitiallizerKasi : DropCreateDatabaseAlways<Model1>
        {
            protected override void Seed(Model1 context)
            {
                context.People.Add(new Student
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Semestr = 6,
                    EnrollmentDate=DateTime.Now
                });
                context.People.Add(new Instructor
                {
                    FirstName = "Adam",
                    LastName = "Nowak",
                    HireDate = DateTime.Now,
                    IloscCertyfikatow = 3
                });
                context.Courses.Add(new OnsiteCourse
                {
                    Date = DateTime.Now,
                    Location = "Bielsko-Biala",
                    Time = DateTime.Now,
                    Title = "abc"
                });
                context.Courses.Add(new OnsiteCourse
               {
                    Date = DateTime.Now,
                    Location = "Bielsko-Biala",
                    Time = DateTime.Now,
                    Title = "abcdf"
                });                     
                                         
                context.SaveChanges();
                base.Seed(context);
            }            
        }
    }
}
   