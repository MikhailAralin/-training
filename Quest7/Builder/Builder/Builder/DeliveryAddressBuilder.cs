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
            Console.Write("введите улицу:");
            var street = Console.ReadLine();
            _deliveryAddress.Street = street;
        }
        public override void BuildHouse()
        {
            var house = CheckData.CheckInt("номер дома");
            _deliveryAddress.House = house;
        }
        public override void BuildApartmentNumber()
        {
            var apartmentNumber = CheckData.CheckInt("номер квартиры");

            _deliveryAddress.ApartmentNumber = apartmentNumber;
        }
    }
}
