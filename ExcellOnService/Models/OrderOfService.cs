using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class OrderOfService
    {
        public OrderOfService()
        {
            OrderOfServiceDetail = new HashSet<OrderOfServiceDetail>();
        }

        public Guid OrderOfServiceId { get; set; }
        public string OrderOfServiceDescription { get; set; }
        public int OrderOfServicePrice { get; set; }
        public DateTime OrderOfServiceCreatedAt { get; set; }
        public string OrderOfServicePaymentMethod { get; set; }
        public DateTime OrderOfServicePaymentDate { get; set; }
        public DateTime OrderOfServiceBillDate { get; set; }
        public int OrderOfServiceStatus { get; set; }
        public bool OrderOfServiceIsDelete { get; set; }

        public virtual ICollection<OrderOfServiceDetail> OrderOfServiceDetail { get; set; }
    }
}
