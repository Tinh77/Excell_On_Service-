using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Dealer
    {
        public Guid DealerId { get; set; }
        public Guid CompanyId { get; set; }
        public string DealerName { get; set; }
        public string DealerAddress { get; set; }
        public string DealerPhone { get; set; }
        public string DealerEmail { get; set; }
        public bool DealerIsDelete { get; set; }

        public virtual Company Company { get; set; }
    }
}
