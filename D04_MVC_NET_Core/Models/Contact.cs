using System;
using System.Collections.Generic;

namespace D04_MVC_NET_Core.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Addresses = new HashSet<Address>();
        }

        public int ContactId { get; set; }
        public string ContactName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
