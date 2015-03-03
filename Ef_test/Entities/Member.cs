using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_test
{
    public class Member
    {
        public enum eMemberTitle
        {
            Developer,
            TeamLeader,
            ScrumMaster,
            Tester
        }
        public int Id { get; set; }
        
        public virtual Team Team { get; set; }
        [ForeignKey("Team")]
        public int ? TeamId { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public string Name { get; set; }
        public eMemberTitle MemberTitle { get; set; }
        public Member()
        {
            Projects= new HashSet<Project>();
        }
    }
}
