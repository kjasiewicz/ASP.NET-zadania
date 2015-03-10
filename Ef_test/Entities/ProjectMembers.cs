using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test
{
    [Table("ProjektyUzytkownicy")]
    public class ProjectMembers
    {
        [Key]
        public int ProjectMemberId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Member Member { get;set; }
        public virtual Project Project { get; set; }
    }
}
