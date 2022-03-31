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

        public int serve(Drink drink)
        {

            if (this.drink.getPrice() == drink.getPrice())
            {
                return drink.getPrice();
            }
            else
            {
                return 0;
            }

        }

        public int serveWithCup(Drink drink)
        {

            if (this.drink.getPrice() == drink.getPrice() && this.getCupFound() == true)
            {
                return drink.getPrice();
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

        public void  SetCupFound(bool isCupFound)
        {
           this.cupFound = isCupFound;
        }





    }
}
