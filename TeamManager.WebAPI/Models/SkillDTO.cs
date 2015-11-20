using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamManager.Domain.Common;

namespace TeamManager.WebAPI.Models
{
    public class SkillDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public ICollection<MemberDTO> Members { get; set; }
    }
}
