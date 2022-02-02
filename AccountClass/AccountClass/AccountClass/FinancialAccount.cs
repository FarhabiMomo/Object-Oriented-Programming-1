using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
   internal static class FinancialAccount
    {
        private static Account[] account = new Account[1000];
        private static int count = 0;

        internal static void AddAccount(Account a)
        {
            account[count] = a;
            count++;
        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                if (account[index] != null)
                {
                    account[index].ShowInfo();
                }
                index++;
            }
        }

        internal static void Withdraw(string key,double amount)
        {
            int index;
            bool decision = SearchIndividual(key, out index);
            if (decision)
            {
                account[index].Withdraw(amount);
            }
            
        }

        internal static void Deposit(string key, double amount)
        {
            int index;
            bool decision = SearchIndividual(key, out index);
            if (decision)
            {
                account[index].Deposit(amount);
            }
            
        }

        internal static void Transfer(string senderKey,string receiverKey,double amount)
        {
            int sid, rid;
            bool decision = SearchIndividual(senderKey, out sid);
            decision = SearchIndividual(receiverKey, out rid);
            if (decision)
            {
                if (account[sid].Withdraw(amount))
                {
                    account[rid].Deposit(amount);
                    Console.WriteLine("Transfer of {0} Taka from {1} Account's to {2} Account's is Complete", amount, account[sid].Name, account[rid].Name);
                }
                else
                {
                    Console.WriteLine("Sender Doesn't Have Enough Money");
                }
            }

        }

        internal static void CheckBalance(string id)
        {
            int index;
            bool decision = SearchIndividual(id, out index);
            string name = account[index].Name;
            double balance = account[index].Balance;
            if (decision)
            {
                Console.WriteLine("{0}'s Account has {1} Taka",name,balance);
            }
        }

        internal static void showInformationById(int index)
        {
                account[index].ShowInfo();
        }

        internal static bool SearchIndividual(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    found = true;
                    i = index;
                    return found; //break;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not found");
            return found;
        }
        internal static void DeleteAccount(string key)
        {
            int index;
            bool decision = SearchIndividual(key, out index);
            string name = account[index].Name;
            if (decision)
            {
                account[index] = null;
                Console.WriteLine(name + "'s Account has been deleted.");
            }
        }
    }
}

