using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamManager.Domain.Common;

namespace TeamManager.WebAPI.Models
{
    public class MemberDTO
    {

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public GenderDTO Gender { get; set; }

        public string Bio { get; set; }

        public string ProfilePicture { get; set; }

        public virtual ICollection<SkillDTO> Skills { get; set; }
        public virtual ICollection<CertificationDTO> Certifications { get; set; }

        public virtual ICollection<LeaveDTO> Leaves { get; set; }

        //public virtual ICollection<TeamDTO> Teams { get; set; }
    }
}
