using System;
using System.Collections.Generic;

namespace D04_MVC_NET_Core.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int ContactId { get; set; }
        public string ContactAddress { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public virtual Contact Contact { get; set; } = null!;
    }
}
