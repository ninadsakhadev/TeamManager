using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace TeamManager.Domain.Common
{
    public abstract class Entity : IObjectState
    {
        [NotMapped][JsonIgnore]
        public ObjectState ObjectState { get; set; }
    }
}
