using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    internal class Loan:Account
    {
        internal override string Id
        {
            set { base.Id = "L-" + value; }
        }

        internal Loan( string name, MyDate dateOfBirth, OurAddress address, double balance) : base( name, dateOfBirth, address, balance)
        {
            
        }
        internal override bool Withdraw(double amount)
        {
            if(this.Balance > (amount+50))
            {
                amount += 50;
                base.Withdraw(amount);
                Console.WriteLine("Withdraw of {0} amount is Completed", amount);
                return true;
            }
            else
            {
                Console.WriteLine("You cannot Withdraw not sufficient Balance!!!");
                return false;
            }
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}

