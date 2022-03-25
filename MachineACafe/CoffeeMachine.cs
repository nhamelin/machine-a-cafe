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
        private bool cupFound;

        public CoffeeMachine()
        {
            //this.drink = new Drink("",0);
        }

        public int serve(string name, int price)
        {
           // Drink drink = new Drink(name, price); 
            if (this.drink.getPrice() == price)
            {
                return price;
            }
            else
            {
                return 0;
            }

        }

        public bool IscupFound()
        {
            reti
        }
        public bool getCupFound()
        {
            return this.cupFound;
        }
    }
}
