using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Service = new HashSet<Service>();
        }

        public Guid EmployeeId { get; set; }
        public Guid DepartmentId { get; set; }
        public string EmployeeFirtName { get; set; }
        public string EmployeeLastName { get; set; }
        public bool? EmployeeGender { get; set; }
        public DateTime? EmployeeDateOfBirth { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAvatar { get; set; }
        public bool EmployeeIsDelete { get; set; }

        public virtual Department Department { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
