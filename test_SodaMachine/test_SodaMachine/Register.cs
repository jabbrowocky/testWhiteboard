using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    class Register
    {
        public List<Coin> register = new List<Coin>();
        public Register(int quarters, int dimes, int nickels, int pennies)
        {

        }
        void AddCoins(int quarters, int dimes, int nickels, int pennies)
        {
            for (int i = 0; i <= quarters; i++)
            {
                register.Add(new Quarter());
            }
            for (int i = 0; i <= dimes; i++)
            {
                register.Add(new Dime());
            }
            for (int i = 0; i <= nickels; i++)
            {
                register.Add(new Nickel());
            }
            for (int i = 0; i <= pennies; i++)
            {
                register.Add(new Penny());
            }
        }
    }
}
