using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class CoffeeMachine
    {

        public Drink drink;

        public CoffeeMachine()
        {
            //this.drink = new Drink("",0);
        }

        public int serve(Drink drink)
        {
           // Drink drink = new Drink(name, price); 
            if (this.drink.getPrice() == drink.getPrice())
            {
                return drink.getPrice();
            }
            else
            {
                return 0;
            }

        }
    }
}
