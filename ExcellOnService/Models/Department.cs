using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public bool DepartmentIsDelete { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
