using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class CurrentAccount : Account
    {

        /*
        internal override void Transfer(string sender, string receiver, double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 2000)
                {
                    base.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than 2000 at once!!!");
                }
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance in your Account!!!");
            }
        }*/

        internal override bool Withdraw(double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 5000)
                {
                    base.Withdraw(amount);
                    Console.WriteLine("Withdraw of {0} amount is Completed", amount);
                    return true;
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than 5000 at once!!!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance in your Account!!!");
                return false;
            }
        }
       
        internal override string Id
        {
            set { base.Id = "C-" + value; }
        }

        internal CurrentAccount(string name, MyDate dateOfBirth, OurAddress address, double balance) : base(name, dateOfBirth, address, balance)
        {

        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
