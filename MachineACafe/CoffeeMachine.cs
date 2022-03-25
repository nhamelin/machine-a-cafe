using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class CoffeeMachine
    {

        private Expresso expresso;

        public CoffeeMachine(Expresso exposso)
        {
            this.expresso = expresso;
        }

        public int serve(int price)
        {

            int res = 0;
            Expresso exprs = new Expresso(price); 
            if (exprs.getPrice() == price)
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
