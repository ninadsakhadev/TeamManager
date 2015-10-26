using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamManager.Domain.Common;

namespace TeamManager.Domain
{
    public class Leave:Entity
    {
        public int Id { get; set; }
        public string Reason { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
