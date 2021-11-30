using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class Incident
    {
        public Incident()
        {
            IncidentBuilding = new HashSet<IncidentBuilding>();
            UserIncident = new HashSet<UserIncident>();
        }

        public int IId { get; set; }
        public string UName { get; set; }
        public string IBuildingName { get; set; }
        public DateTime? IDate { get; set; }
        public string IDescription { get; set; }
        public string ISupplierName { get; set; }
        public string ISupplierCompany { get; set; }
        public string ISupplierComment { get; set; }
        public string IReportApproval { get; set; }
        public string IWorkApproval { get; set; }
        public string IWorkStatus { get; set; }
        public string IUserFeedBack { get; set; }
        public string IWorkAcceptance { get; set; }
        public string ICaretakerComment { get; set; }
        public int? IWorkDuration { get; set; }

        public virtual ICollection<IncidentBuilding> IncidentBuilding { get; set; }
        public virtual ICollection<UserIncident> UserIncident { get; set; }
    }
}
