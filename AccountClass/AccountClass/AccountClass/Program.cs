using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Program
    {
        internal static void Display()
        {
            Console.WriteLine("1. Add new Account");
            Console.WriteLine("2. Search Account");
            Console.WriteLine("3. Show all Account Information");
            Console.WriteLine("4. Delete Account");
            Console.WriteLine("5. Deposit");
            Console.WriteLine("6. Withdraw");
            Console.WriteLine("7. Transfer");
            Console.WriteLine("8. Check Balance");
            Console.WriteLine("9. Exit System");
        }
        internal static void StartSystem()
        {
            int choose = 0;
            while (choose != 9)
            {
                Display();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("What Type Of Account Do you want to Create?\n1.Savings\n2.Loan\n3.Current");
                        int actype = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Account's Holder Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Birth date:");
                        byte day = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Enter Birth Month:");
                        string month = Console.ReadLine();
                        Console.WriteLine("Enter Birth Year:");
                        ushort year = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine("Enter Appartment Number:");
                        int apartmentNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Road Number:");
                        string roadNoName = Console.ReadLine();
                        Console.WriteLine("Enter District:");
                        string district = Console.ReadLine();
                        Console.WriteLine("Enter Country: ");
                        string country= Console.ReadLine();

                        if(actype ==1)
                        {
                            FinancialAccount.AddAccount(new SavingsAccount(name, new MyDate(day, month, year), new OurAddress(apartmentNumber, roadNoName,district, country), 0));
                        }
                        else if(actype == 2)
                        {
                            FinancialAccount.AddAccount(new Loan(name, new MyDate(day, month, year), new OurAddress(apartmentNumber, roadNoName, district, country), 0));
                        }
                        else if(actype == 3)
                        {
                            FinancialAccount.AddAccount(new CurrentAccount(name, new MyDate(day, month, year), new OurAddress(apartmentNumber, roadNoName, district, country), 0));
                        }
                        else
                        {
                            Console.WriteLine("You Selected a Wrong Account type!!!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Account Id:");
                        string id = Console.ReadLine();
                        int i;
                        if (FinancialAccount.SearchIndividual(id,out i))
                        {
                            FinancialAccount.showInformationById(i);
                        }
                        break;
                    case 3:
                        FinancialAccount.ShowAll();
                        break;
                    case 4:
                        Console.WriteLine("Enter Account Id:");
                        id = Console.ReadLine();
                        FinancialAccount.DeleteAccount(id);
                        break;
                    case 5:
                        Console.WriteLine("Enter Account Id:");
                        id = Console.ReadLine();
                        Console.WriteLine("Enter Deposit Amount:");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        FinancialAccount.Deposit(id, amount);
                        break;
                    case 6:
                        Console.WriteLine("Enter Account Id:");
                        id = Console.ReadLine();
                        Console.WriteLine("Enter Withdraw Amount:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        FinancialAccount.Withdraw(id, amount);
                        break;
                    case 7:
                        Console.WriteLine("Enter Sender Account Id:");
                        string sid = Console.ReadLine();
                        Console.WriteLine("Enter Receiver Account Id:");
                        string rid = Console.ReadLine();
                        Console.WriteLine("Enter Transfer Amount:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        FinancialAccount.Transfer(sid,rid, amount);
                        break;
                    case 8:
                        Console.WriteLine("Enter Account Id:");
                        id = Console.ReadLine();
                        FinancialAccount.CheckBalance(id);
                        break;
                    case 9:
                        Console.WriteLine("Thank you for Banking With Us!!!");
                        break;
                    default:
                        Console.WriteLine("You have input a Wrong Number Please Select a Valid option!!!");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            StartSystem();            
        }
        }
    }

