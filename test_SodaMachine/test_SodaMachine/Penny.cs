using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    class Penny:Coin
    {
        public Penny()
        {
            this.Value = .01;
            this.Name = "Penny";
        }
    }
}
