using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            Service = new HashSet<Service>();
        }

        public Guid ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }

        public virtual ICollection<Service> Service { get; set; }
    }
}
