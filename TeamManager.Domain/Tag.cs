using TeamManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Domain
{
    public class Tag : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
