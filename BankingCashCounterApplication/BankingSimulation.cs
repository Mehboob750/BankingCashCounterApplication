using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Schema;

namespace BankingCashCounterApplication
{
    public class BankingSimulation
    {
        public static void CashDeposite(LinkedList linkedList)
        {
            string name = ReadName(linkedList);
            Console.WriteLine("Enter Amount You Want To Deposite");
            int amount = Convert.ToInt32(Console.ReadLine());
            int balance = (int)linkedList.UpdateBalance(name, amount);
            Console.WriteLine("Your Current Balance After Deposite is:\t" + balance);
        }

        public static void CashWithdrawal(LinkedList linkedList)
        {
            string name = ReadName(linkedList);
            Console.WriteLine("Enter Amount You Want To WithDraw");
            int amount = Convert.ToInt32(Console.ReadLine());
            int balance = (int)linkedList.WithdrawBalance(name, amount);
            Console.WriteLine("Your Current Balance After WithDraw is:\t" + balance);
        }

        public static string ReadName(LinkedList linkedList)
        {
            String name;
            while (true)
            {
                Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
                if (linkedList.CheckCustomer(name) == false)
                    Console.WriteLine("Please Enter Proper Name");
                else
                    break;
            }
            return name;
        }

    }
}
