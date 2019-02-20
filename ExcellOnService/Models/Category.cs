using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryIsDelete { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
