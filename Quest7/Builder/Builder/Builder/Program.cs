using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Director
    {
        public void Construct(DeliveryAddressBuilderBase builder)
        {
            builder.BuildIndex();
            builder.BuildCountry();
            builder.BuildCity();
            builder.BuildStreet();
            builder.BuildHouse();
            builder.BuildApartmentNumber();
        }
        public static void Main()
        {
            Director director = new Director();
            DeliveryAddressBuilderBase address = new DeliveryAddressBuilder();
            director.Construct(address);
            Console.WriteLine(address.GetAddress());
            Console.Read();
        }
    }
}