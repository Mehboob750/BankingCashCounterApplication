using System;

namespace BankingCashCounterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Banking Cash Counter");
            LinkedList linkedList = new LinkedList();
            linkedList.InsertData("Akshay Kumar", 35000);
            linkedList.InsertData("Rahul Roy", 2000);
            linkedList.InsertData("Rajesh Patil", 2000);
            linkedList.RemoveRecord();
            Console.WriteLine(linkedList.IsEmpty());
            Console.WriteLine(linkedList.CheckCustomer("Rahul Roy"));
            linkedList.DisplayAllRecords();
        }
    }
}
