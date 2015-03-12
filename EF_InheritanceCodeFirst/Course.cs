namespace EF_InheritanceCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public abstract class Course
    {
        public Course()
        {
            People = new HashSet<Person>();
        }

        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }  
        public virtual ICollection<Person> People { get; set; }
    }
    public class OnlineCourse : Course
    {
        public string URL { get; set; }
    }
    public class OnsiteCourse : Course
    {
        public string Location { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? Time { get; set; }
    }
}
