using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Product
    {
        public Guid ProductId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public DateTime? ProductManufactureDate { get; set; }
        public DateTime? ProductExpiryDate { get; set; }
        public bool ProductIsDelete { get; set; }

        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
    }
}
