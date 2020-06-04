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
            int amount = ReadAmount(linkedList);
            int balance = (int)linkedList.UpdateBalance(name, amount);
            Console.WriteLine("Your Current Balance After Deposite is:\t" + balance);
        }

        public static void CashWithdrawal(LinkedList linkedList)
        {
            string name = ReadName(linkedList);
            int amount = ReadAmount(linkedList);
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

        public static int ReadAmount(LinkedList linkedList)
        {
            Console.WriteLine("Enter Amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            return amount;
        }

        public static void CheckBalance(LinkedList linkedList)
        {
            string name = ReadName(linkedList);
            if (linkedList.CheckCustomer(name))
            {
                int balance = linkedList.ShowBalance(name);
                Console.WriteLine("Name:" + name + "\tBalance:" + balance);
            }
            else
                Console.WriteLine("Please Enter Valid data");
        }
    }
}
