using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamManager.Domain.Common;

namespace TeamManager.Domain
{
    public class Member:Entity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public string Bio { get; set; }

        public string ProfilePicture { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }

        public virtual ICollection<Leave> Leaves { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
