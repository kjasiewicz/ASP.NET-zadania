using Ef_test.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Ef_test.Entities;
using System.Data.Entity;
using Ef_test.Entities.TPH;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Ef_test
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
                AppDomain.CurrentDomain.BaseDirectory);

            using (var db = new TestContext())
            {
                //    var q = from x in db.Persons.OfType<Student>()
                //            select x;
                //    foreach (var item in q)

                //    {
                //        Console.WriteLine(item.Name);
                //    }
                //    db.Schools.Add(new School
                //    {                  
                //        Persons= new List<Person>
                //        {
                //            new Teacher{Name="Tengler", Title="PhD"},
                //            new Teacher{Name="Gancarczyk", Title="PhD"},
                //            new Student{Name="Kasia", IndexNo=43571},
                //            new Student{Name="Tomasz", IndexNo=43561},
                //            new Student{Name="Krzysztof", IndexNo=43571}
                //            }
                //        }

                //    );
                //    db.SaveChanges();

                //    var q = from x in db.Members.Include(n=>n.Team)
                //            select x;

                //    foreach (var item in q.ToList())
                //    {
                //        //db.Database.Log = (n) => Console.WriteLine(n);

                //        //db.Configuration.LazyLoadingEnabled = false;
                //        Console.WriteLine("Team Name: {0}, member name: {1}",
                //        item.Team.Name,
                //        item.Name);
                //    }
                //    var athTeam = new Team { Name = "ATH" };
                //    athTeam.Members.Add(new Member
                //    {
                //        Name="Jaś",
                //        MemberTitle=Ef_test.Member.eMemberTitle.Developer
                //    });

                //    athTeam.Members.Add(new Member
                //        {
                //            Name = "Małogosia",
                //            MemberTitle = Ef_test.Member.eMemberTitle.ScrumMaster
                //        });

                //    db.Teams.Add(athTeam);
                //    db.SaveChanges();
                //    db.Teams.Add(new Team
                //    {
                //        Name = "Miszczowie",
                //        Members = new List<Member> 
                //        {
                //            new Member{Name= "Member1",MemberTitle=Ef_test.Member.eMemberTitle.Developer},
                //            new Member{Name= "Member2",MemberTitle=Ef_test.Member.eMemberTitle.Developer}
                //        }

                //    });
                //    db.SaveChanges();
                //}da
                DateTime m = DateTime.Now;
                var k = db.Projects.Select(n =>
                    n).ToList();
                Console.WriteLine(DateTime.Now - m);
                foreach (var item in k)
                {
                    Console.WriteLine(item.Name);
                }                             
            }
            var con = ConfigurationManager.ConnectionStrings["TestContext"].ConnectionString;
            using (var a = new SqlConnection(con))
            {
                DateTime l = DateTime.Now;
                //var b = a.Query<Member>("select Imie, Id from Members").Select(n=>
                //    new 
                //    {
                //        n.Name,
                //        n.Id
                //    }).ToList();
                var b = a.GetList<Project>().Select(n =>
                    new
                    {
                        n.Name
                    }).ToList();
                Console.WriteLine(DateTime.Now-l);
                foreach (var item in b)
                {
                    Console.WriteLine(item.Name);
                }
            }
            
        }
    }
}
    
    


