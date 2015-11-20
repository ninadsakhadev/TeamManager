using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Domain.Common;

namespace TeamManager.WebAPI.Models
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MemberDTO> Members { get; set; }
    }
}
