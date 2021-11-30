using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class BuildingUnit
    {
        public BuildingUnit()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int BuId { get; set; }
        public int? BuNumber { get; set; }
        public string BuName { get; set; }
        public int? BId { get; set; }

        public virtual Building B { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
