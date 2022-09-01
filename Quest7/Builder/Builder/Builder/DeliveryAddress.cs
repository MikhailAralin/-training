using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DeliveryAddress
    {
        public string Index { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string ApartmentNumber { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(Index)
            .Append(Country)
            .Append(City)
            .Append(Street)
            .Append(House)
            .Append(ApartmentNumber)
            .ToString();
    }
}
