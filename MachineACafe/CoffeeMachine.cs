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
        }

        public int serve(string name, int price)
        {

            if (this.drink.getPrice() == price)
            {
                return price;
            }
            else
            {
                return 0;
            }

        }

        public int serveWithCup(string name, int price)
        {

            if (this.drink.getPrice() == price && this.getCupFound() == true)
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
            return getCupFound();
        }
        public bool getCupFound()
        {
            return this.cupFound;
        }




    }
}
