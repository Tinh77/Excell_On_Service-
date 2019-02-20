using System;
using System.Collections.Generic;

namespace ExcellOnService.Models
{
    public partial class Company
    {
        public Company()
        {
            Dealer = new HashSet<Dealer>();
            Product = new HashSet<Product>();
            Service = new HashSet<Service>();
        }

        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyAddress { get; set; }
        public bool CompanyIsDelete { get; set; }

        public virtual ICollection<Dealer> Dealer { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
