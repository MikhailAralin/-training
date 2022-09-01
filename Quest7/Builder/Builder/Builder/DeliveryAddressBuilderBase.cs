using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class DeliveryAddressBuilderBase
    {
        protected DeliveryAddress _deliveryAddress;
        public abstract void BuildIndex();
        public abstract void BuildCountry();
        public abstract void BuildCity();
        public abstract void BuildStreet();
        public abstract void BuildHouse();
        public abstract void BuildApartmentNumber();

        public virtual string GetAddress()
        {
            return _deliveryAddress.ToString();
        }
    }
}
