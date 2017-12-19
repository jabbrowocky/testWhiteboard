using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    class SodaMachine
    {

        SodaInventory availableSoda = new SodaInventory(15, 15, 15);
        Register coinage = new Register(20, 10, 20, 50);
        List<Coin> yourPayment = new List<Coin>();
        bool machineIsOn = true;

        public SodaMachine()
        {
            

        }
        Soda PurchaseSoda(string sodaName)
        {
            Soda yourSoda;

            if (CheckAvailability(sodaName) == true)
            {
                yourSoda = CreatePurchaseableSoda(sodaName);
                return yourSoda;
            }
            return null;
        }
        Soda CreatePurchaseableSoda(string sodaName)
        {
            Soda sodaCreated;
            foreach(KeyValuePair<int, Soda> soda in availableSoda.sodaInventory)
            {
                if (soda.Value.Name.ToLower() == sodaName.ToLower())
                {
                    sodaCreated = soda.Value;
                    availableSoda.sodaInventory.Remove(soda.Key);
                    return sodaCreated;
                }
                
            }
            return null;
        }
        bool CheckAvailability(string soda)
        {
            bool isAvailable = false;
            foreach(KeyValuePair<int, Soda> sodaName in availableSoda.sodaInventory)
            {
                if (sodaName.Value.Name.ToLower() == soda.ToLower())
                {
                    isAvailable = true;
                    return isAvailable;
                }
            }
            if (isAvailable == false)
            {
                Console.WriteLine("{0} is out of stock, press any key to make another selection",soda);
                Console.ReadKey();
                
            }
            return isAvailable;
        }
        void HandleMoney(Soda soda)
        {
            double paymentValue = 0;
            Console.WriteLine("Please deposit {0:C2} in coins", soda.Price);
            MakePayment();
            for(int i = 0; i < yourPayment.Count(); i++)
            {
                paymentValue += yourPayment[i].Value;
            }
            ComparePayment(soda, paymentValue);
        }
        void ComparePayment(Soda soda, double paymentValue)
        {
            
            if (soda.Price == paymentValue)
            {
                DispenseSoda(soda);
            }
            if (soda.Price > paymentValue)
            {
                Console.WriteLine("No Dice");
                
                Console.WriteLine("Here's your money back");
                foreach (Coin coin in yourPayment)
                {
                    Console.WriteLine("{0}: {1}", coin.Name);
                }
                Console.ReadKey();
            }
            if (soda.Price < paymentValue)
            {
                double difference = paymentValue - soda.Price;

            }
        }
        void CalculateReturn(double difference)
        {
            Nickel nickel = new Nickel();
            Dime dime = new Dime();
            Quarter quarter = new Quarter();
            Penny penny = new Penny();
            
        }
        void DispenseSoda(Soda soda)
        {
            Console.WriteLine("Here's your {0} soda", soda.Name);
        }
        public List<Coin> MakePayment()
        {
            int Quarters;
            int Dimes;
            int Nickels;
            int Pennies;
            
            Console.WriteLine("How many Quarters?");
            Quarters = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Dimes?");
            Dimes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Nickels?");
            Nickels = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Pennies?");
            Pennies = int.Parse(Console.ReadLine());
            for(int i = 0; i < Quarters; i++)
            {
                yourPayment.Add(new Quarter());
            }
            for(int i = 0; i < Dimes; i++)
            {
                yourPayment.Add(new Dime());
            }
            for(int i = 0; i < Nickels; i++)
            {
                yourPayment.Add(new Nickel());
            }
            for (int i = 0; i < Pennies; i++)
            {
                yourPayment.Add(new Penny());
            }
            return yourPayment;
        }

        public void RunMachine()
        {
            string sodaPurchase;
            Soda yourSoda;
            while (machineIsOn)
            {
                
                Console.WriteLine("Welcome to my soda machine, please type the name of the soda you would like\n\nWe have Grape, Orange, and Lemon to select from");
                sodaPurchase = Console.ReadLine();
                yourSoda = PurchaseSoda(sodaPurchase);
                if (yourSoda != null)
                {
                    HandleMoney(yourSoda);
                    Console.Clear();
                }
                if (availableSoda.sodaInventory.Count == 0)
                {
                    Console.WriteLine("Everything is out of stock, have a nice day!");
                    Console.ReadKey();
                    machineIsOn = false;
                }
            }
        }
       
    }
}
