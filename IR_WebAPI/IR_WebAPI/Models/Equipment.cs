using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class Equipment
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int? EQuantity { get; set; }
        public int? BuId { get; set; }

        public virtual BuildingUnit Bu { get; set; }
    }
}
