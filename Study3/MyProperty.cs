using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study3
{
    public class MyProperty
    {
        private int propNumber;
        private string suburb;
        private int bedrooms;
        private double price;
        #region props
        public int PropNumber
        {
            get
            {
                return propNumber;
            }

            set
            {
                propNumber = value;
            }
        }

        public string Suburb
        {
            get
            {
                return suburb;
            }

            set
            {
                suburb = value;
            }
        }

        public int Bedrooms
        {
            get
            {
                return bedrooms;
            }

            set
            {
                bedrooms = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }

        }
        #endregion
        public MyProperty()
        {

        }
        public MyProperty(int propNumber, string suburb, int bedrooms, double price)
        {
            this.propNumber = propNumber;
            this.suburb = suburb;
            this.bedrooms = bedrooms;
            this.price = price;
        }

        public string PrintInfo()
        {
            return PropNumber + ", " + suburb + ", " + bedrooms + ", " + price;
        }
    }
   

}
