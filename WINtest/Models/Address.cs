using System;
using System.Collections.Generic;

#nullable disable

namespace WINtest.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int? PersonId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
