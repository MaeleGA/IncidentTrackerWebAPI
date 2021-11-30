using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IR_WebAPI.Models
{
    public class UserWithToken: UserAccount
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public UserWithToken(UserAccount user)
        {
            this.UId = user.UId;
            this.UEmail = user.UEmail;
            this.UPassword = user.UPassword;
            this.UName = user.UName;
            this.USurname = user.USurname;
            this.UAddress = user.UAddress;
            this.UContact = user.UContact;

            this.URole = user.URole;
        }
    }
}
