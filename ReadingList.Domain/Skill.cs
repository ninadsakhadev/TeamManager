using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamManager.Domain.Common;

namespace TeamManager.Domain
{
    public class Skill :Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
