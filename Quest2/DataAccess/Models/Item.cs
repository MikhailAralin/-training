using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Item
    {
        public short Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
