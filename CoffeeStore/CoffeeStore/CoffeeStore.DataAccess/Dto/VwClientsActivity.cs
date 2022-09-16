using System;
using System.Collections.Generic;

namespace CoffeeStore.DataAccess.Dto
{
    public partial class VwClientsActivity
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int? TotalAmount { get; set; }
    }
}
