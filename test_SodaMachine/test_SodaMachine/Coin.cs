using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    abstract class Coin
    {
        double value;
        string name;
        public double Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
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
