using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test
{
    [Table("Project")]
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProjectMembers> ProjectMembers { get; set; }
        public Project()
        {
            ProjectMembers = new HashSet<ProjectMembers>();
        }
    }
}
