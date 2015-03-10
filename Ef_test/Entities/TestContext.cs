using Ef_test.Entities.TPH;
using Ef_test.Entities.TPTInheritance;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test.Entities
{
    public class TestContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectMembers> ProjectMembers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
            //modelBuilder.Entity<Member>().HasMany(n =>
            //    n.Projects).WithMany(n =>
            //    n.Members).Map(n =>
            //    {
            //        n.ToTable("MembersProject");
            //        n.MapLeftKey("ProjectId");
            //        n.MapRightKey("MemberId");
            //    });

        //    modelBuilder.Entity<Member>().Property(n =>
        //        n.Name).HasColumnName("Imie");
        //    base.OnModelCreating(modelBuilder);
        //}
        //public class DbInitializer : DropCreateDatabaseIfModelChanges<TestContext>
        //{
        //    protected override void Seed(TestContext context)
        //    {
        //        context.Teams.Add(new Team
        //        {
        //            Name = "SuperImie",
        //            Members = new List<Member>
        //            {
        //                new Member
        //                {
        //                    MemberTitle = Ef_test.Member.eMemberTitle.Developer,
        //                    Name="SuperMember",                            
        //                },
        //                new Member
        //                {
        //                    MemberTitle = Ef_test.Member.eMemberTitle.ScrumMaster,
        //                    Name="SuperMember2",                            
        //                }
        //            }
        //        });
        //        context.SaveChanges();
        //        context.Teams.Add(new Team
        //        {
        //            Name = "SuperImie2",
        //            Members = new List<Member>
        //            {
        //                new Member
        //                {
        //                    MemberTitle = Ef_test.Member.eMemberTitle.Developer,
        //                    Name="SuperMember3",                            
        //                },
        //                new Member
        //                {
        //                    MemberTitle = Ef_test.Member.eMemberTitle.ScrumMaster,
        //                    Name="SuperMember4",                           
        //                }
        //            }
        //        });
        //        context.SaveChanges();
        //        context.Projects.Add(new Project
        //        {
        //            Name = "Projekt1",
        //            ProjectMembers = new List<ProjectMembers>
        //            {
        //                new ProjectMembers {MemberId = 1,StartDate = DateTime.Now},
        //                new ProjectMembers {MemberId = 3,StartDate = DateTime.Now}
        //            }
        //        });
        //        context.SaveChanges();
        //        context.Schools.Add(new School
        //        {
        //            Persons = new List<Person>
        //            {
        //                new Teacher {Name = "Teacher1", Title = "Asd"},
        //                new Teacher {Name = "Teacher2", Title = "Asd2"},
        //                new Student {Name = "Teacher1", IndexNo = 1231},
        //                new Student {Name = "Teacher2", IndexNo = 4324},
        //            }
        //        });
        //        context.SaveChanges();
        //        base.Seed(context);
        //    }
        //}



        //TPH
        public DbSet<School> Schools { get; set; }
        public DbSet <Person> Persons { get; set; }

        //TPT
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

