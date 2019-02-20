using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class News
    {
        public Guid NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public DateTime NewsDate { get; set; }
        public bool NewsIsDelete { get; set; }
    }
}
