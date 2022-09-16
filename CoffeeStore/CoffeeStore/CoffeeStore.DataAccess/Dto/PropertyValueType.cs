using System;
using System.Collections.Generic;

namespace CoffeeStore.DataAccess.Dto
{
    public partial class PropertyValueType
    {
        public short Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
