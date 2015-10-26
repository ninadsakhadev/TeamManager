using TeamManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Domain
{
    public class Link : Entity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string[] KeyWords { get; set; }
    }
}
