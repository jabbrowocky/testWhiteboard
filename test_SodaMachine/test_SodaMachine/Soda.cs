using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    abstract class Soda
    {
        double price;
        string name;
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
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
