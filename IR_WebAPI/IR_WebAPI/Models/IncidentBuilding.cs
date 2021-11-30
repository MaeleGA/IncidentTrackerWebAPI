using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class IncidentBuilding
    {
        public int IId { get; set; }
        public int BId { get; set; }

        public virtual Building B { get; set; }
        public virtual Incident I { get; set; }
    }
}
