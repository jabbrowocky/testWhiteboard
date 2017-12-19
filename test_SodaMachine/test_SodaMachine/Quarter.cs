using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    class Quarter:Coin
    {
        
        public Quarter()
        {
            this.Value = .25;
            this.Name = "Quarter";
        }
    }
}
