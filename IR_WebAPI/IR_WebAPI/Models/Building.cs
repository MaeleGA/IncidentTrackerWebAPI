using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class Building
    {
        public Building()
        {
            BuildingUnit = new HashSet<BuildingUnit>();
            IncidentBuilding = new HashSet<IncidentBuilding>();
            UserAccount = new HashSet<UserAccount>();
        }

        public int BId { get; set; }
        public string BName { get; set; }
        public string BAddress { get; set; }

        public virtual ICollection<BuildingUnit> BuildingUnit { get; set; }
        public virtual ICollection<IncidentBuilding> IncidentBuilding { get; set; }
        public virtual ICollection<UserAccount> UserAccount { get; set; }
    }
}
