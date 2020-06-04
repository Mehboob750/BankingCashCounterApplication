using System;
using System.Collections.Generic;
using System.Text;

namespace BankingCashCounterApplication
{
    public class BankingSimulation
    {
        public static void CashDeposite(LinkedList linkedList)
        {
            Console.WriteLine("Enter your Name");
            String name = Console.ReadLine();
            if (linkedList.CheckCustomer(name) == true)
            {
                Console.WriteLine("Enter Amount You Want To Deposite");
                int amount = Convert.ToInt32(Console.ReadLine());
                int balance = (int)linkedList.UpdateBalance(name, amount);
                Console.WriteLine("Your Current Balance After Deposite is:\t" + balance);
            }
            else
                Console.WriteLine("Please Enter Proper Name");
        }

        public static void CashWithdrawal()
        {
            throw new NotImplementedException();
        }
    }
}
