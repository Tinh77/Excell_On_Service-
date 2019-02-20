using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Role
    {
        public Role()
        {
            Account = new HashSet<Account>();
        }

        public string RoleName { get; set; }
        public bool RoleIsDelete { get; set; }

        public virtual ICollection<Account> Account { get; set; }
    }
}
