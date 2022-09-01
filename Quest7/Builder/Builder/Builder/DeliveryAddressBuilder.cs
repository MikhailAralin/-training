using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class DeliveryAddressBuilder : DeliveryAddressBuilderBase
    {
        public DeliveryAddressBuilder()
        {
            _deliveryAddress = new DeliveryAddress();
        }
        public override void BuildIndex()
        {
            var index = CheckData.CheckInt("индекс");
            _deliveryAddress.Index = index;
        }
        public override void BuildCountry()
        {
            var country = CheckData.Check("страну");

            _deliveryAddress.Country = country;
        }
        public override void BuildCity()
        {
            var city = CheckData.Check("город");

            _deliveryAddress.City = city;
        }
        public override void BuildStreet()
        {
            var street = CheckData.Check("улицу");

            _deliveryAddress.Street = street;
        }
        public override void BuildHouse()
        {
            var house = CheckData.Check("номер дома");

            _deliveryAddress.House = house;
        }
        public override void BuildApartmentNumber()
        {
            var apartmentNumber = CheckData.Check("номер квартиры");

            _deliveryAddress.ApartmentNumber = apartmentNumber;
        }
    }
}
