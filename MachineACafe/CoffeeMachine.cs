using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class CoffeeMachine
    {

        private Drink drink;

        public CoffeeMachine(Drink drink)
        {
            this.drink = drink;
        }

        public int serve(string name, int price)
        {

            int res = 0;
            Drink drink = new Drink(name, price); 
            if (drink.getPrice() == price)
            {
                res = price;
                return res;
            }
            else
            {
                return res;
            }

        }
    }
}
