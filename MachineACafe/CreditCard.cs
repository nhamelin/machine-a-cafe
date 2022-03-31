using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    public class CreditCard
    {

        private int balance;
        public CreditCard(int balance)
        {
            this.balance = balance;
        }

        public int getBalance()
        {
            return this.balance;
        }

        public bool checkBalance(int mount)
        {
            if(this.balance < mount)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        

     


}
}
