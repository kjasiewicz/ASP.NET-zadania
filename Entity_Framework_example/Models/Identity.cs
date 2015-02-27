using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace Entity_Framework_example.Models
{
    public class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        [Key]
        public int NrIndeksu { get; set; }
        public virtual ICollection<Telefony> Telefony { get; set; }
        public virtual Adres Adres { get; set; }
        public Student()
        {
            Telefony = new List<Telefony>();
        }
    }

    public class Adres
    {
        public string Ulica { get; set; }
        public string Numer { get; set; }
        public string KodPocztowy { get; set; }
        [Key,ForeignKey("Student")]       
        public int NrIndeksu { get; set; }
        public virtual Student Student { get; set; }
    }

    public class Telefony
    {
        [Key]
        public int Numer { get; set; }
        public string Operator { get; set; }
        public bool CzyKomorkowy { get; set; }
        public int NrIndeksu { get; set; }
        [ForeignKey("NrIndeksu")]
        public virtual Student Student { get; set; }
    }

    public class BazaDanychDbContext:DbContext
    {
        public BazaDanychDbContext()
            : base("BazaDanychDbContext")
        {
         
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Telefony>Telefon { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        }

        public class BazaDanychInitializer : DropCreateDatabaseAlways<BazaDanychDbContext>
        {
            protected override void Seed(BazaDanychDbContext context)
            {
                context.Adres.Add(
                    new Adres
                    {
                        Ulica = "Partyzantów",
                        Numer = "62",
                        NrIndeksu = 43571,
                        KodPocztowy = "32-650"

                    });
                context.Student.Add(
                    new Student
                    {
                        Imie = "Katarzyna",
                        Nazwisko = "Jasiewicz",
                        NrIndeksu = 43571

                    });
                context.Telefon.Add(
                    new Telefony
                    {
                        CzyKomorkowy = true,
                        NrIndeksu = 43571,
                        Numer = 506320031,                       
                        Operator = "play"

                    });
       
                context.SaveChanges();
                base.Seed(context);

            }
        }
    }
    
}