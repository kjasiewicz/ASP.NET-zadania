using Ef_test.Entities.TPH;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        //TPH
        public DbSet<School> Schools { get; set; }
        public DbSet <Person> Persons { get; set; }

    }
}
