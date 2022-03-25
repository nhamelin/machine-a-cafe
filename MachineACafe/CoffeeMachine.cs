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

            int res = 0;
           // Drink drink = new Drink(name, price); 
            if (this.drink.getPrice() == price)
            {
                res = price;
                return res;
            }
            else
            {
                return res;
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
