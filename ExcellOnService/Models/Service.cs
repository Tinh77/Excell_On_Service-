using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Service
    {
        public Service()
        {
            OrderOfServiceDetail = new HashSet<OrderOfServiceDetail>();
        }

        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public int ServicePrice { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceCharge { get; set; }
        public bool ServiceIsDelete { get; set; }
        public Guid EmployeeEmployeeId { get; set; }
        public Guid ServiceTypeServiceTypeId { get; set; }
        public Guid CompanyCompanyId { get; set; }

        public virtual Company CompanyCompany { get; set; }
        public virtual Employee EmployeeEmployee { get; set; }
        public virtual ServiceType ServiceTypeServiceType { get; set; }
        public virtual ICollection<OrderOfServiceDetail> OrderOfServiceDetail { get; set; }
    }
}
