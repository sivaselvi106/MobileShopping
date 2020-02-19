using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Entity
{
    public class Account
    {
        public string UserName { get; set; }
        public string MailId { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public long MobileNo { get; set; }
        public string City { get; set; }
    }
}
