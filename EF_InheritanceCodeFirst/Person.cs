namespace EF_InheritanceCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public abstract class Person
    {
        public Person()
        {
            
            Courses = new HashSet<Course>();
        }

        public int PersonID { get; set; }           
        public string LastName { get; set; }                
        public string FirstName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
    public class Student:Person
    {
        public DateTime? EnrollmentDate { get; set; }
        public int Semestr { get; set; }
    }
    public class Instructor : Person
    {
        public DateTime? HireDate { get; set; }
        public int IloscCertyfikatow { get; set; }
    }
}
