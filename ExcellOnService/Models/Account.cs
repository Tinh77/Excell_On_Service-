using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Account
    {
        public Guid AccountId { get; set; }
        public Guid EmployeeId { get; set; }
        public string RoleName { get; set; }
        public string AccountUserName { get; set; }
        public string AccountPassword { get; set; }
        public bool AccountIsLocked { get; set; }
        public bool AccountIsDelete { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Role RoleNameNavigation { get; set; }
    }
}
