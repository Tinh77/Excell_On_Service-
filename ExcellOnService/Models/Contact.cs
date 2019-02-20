using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Contact
    {
        public Guid ContactId { get; set; }
        public string ContactTitle { get; set; }
        public string ContactContent { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public DateTime ContactDate { get; set; }
        public int ContactStatus { get; set; }
        public bool ContactIsDelete { get; set; }
    }
}
