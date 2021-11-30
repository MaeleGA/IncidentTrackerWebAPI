using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class UserIncident
    {
        public int UId { get; set; }
        public int IId { get; set; }

        public virtual Incident I { get; set; }
        public virtual UserAccount U { get; set; }
    }
}
