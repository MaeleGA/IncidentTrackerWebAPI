using System;
using System.Collections.Generic;

namespace IR_WebAPI.Models
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            UserIncident = new HashSet<UserIncident>();
        }

        public int UId { get; set; }
        public string UEmail { get; set; }
        public string UPassword { get; set; }
        public string UName { get; set; }
        public string USurname { get; set; }
        public string UAddress { get; set; }
        public string UContact { get; set; }
        public string UGender { get; set; }
        public DateTime? UDoB { get; set; }
        public string URole { get; set; }
        public int? BId { get; set; }

        public virtual Building B { get; set; }
        public virtual ICollection<UserIncident> UserIncident { get; set; }
    }
}
