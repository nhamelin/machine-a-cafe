using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class Drink
    {

        private string name;
        private int price;
        public Drink(string name,int price)
        {
            this.name = name;
            this.price = price;
        }

        public int getPrice()
        {
            return this.price;
        }
        public String getName()
        {
            return this.name;
        }

     


}
}
