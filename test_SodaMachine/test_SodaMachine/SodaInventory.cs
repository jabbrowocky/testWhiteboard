using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_SodaMachine
{
    class SodaInventory
    {
        public Dictionary<int, Soda> sodaInventory = new Dictionary<int, Soda>();
        public SodaInventory(int grape, int orange, int lemon)
        {
            
            AddSoda(grape, orange, lemon);
        }

        void AddSoda(int numberOfGrapes, int numberOfOrange, int numberOfLemon)
        {

            GrapeSoda grape = new GrapeSoda();
            OrangeSoda orange = new OrangeSoda();
            LemonSoda lemon = new LemonSoda();        
            for (int i = 1; i < numberOfGrapes; i++)
            {

                sodaInventory.Add(i , new GrapeSoda());
            }
            for (int i = 1; i <= numberOfOrange; i++)
            {
                
                sodaInventory.Add((numberOfGrapes + i), new OrangeSoda());
            }
            for (int i = 1; i <= numberOfLemon; i++)
            {
                
                sodaInventory.Add(numberOfGrapes + numberOfOrange + i, new LemonSoda());
            }
        }
        //public void RemoveSoda (Soda sodaType)
        //{
        //    for (int i = 0; i <= sodaInventory.Count; i ++)
        //    {
        //        if (sodaInventory[i].Name.Equals(sodaType.Name))
        //        {
        //            sodaInventory.RemoveAt(i);
        //            return;
        //        }
        //    }
        //}
    }
}
