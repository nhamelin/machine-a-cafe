using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class Expresso
    {
        private int price;
        public Expresso(int price)
        {
            this.price = price;
        }

        public int getPrice()
        {
            return this.price;
        }


    }
}
