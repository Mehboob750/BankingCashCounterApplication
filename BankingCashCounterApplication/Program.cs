using System;

namespace BankingCashCounterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.InsertRecord("Akshay Kumar", 35000);
            linkedList.InsertRecord("Rahul Roy", 2000);
            linkedList.InsertRecord("Anuskha sharma", 30000);
            linkedList.InsertRecord("Vijay sawant", 12000);
            linkedList.InsertRecord("David Dhawan", 4200);
            linkedList.InsertRecord("Sahil Khan", 35000);
            linkedList.InsertRecord("Rakesh Sharma", 32000);
            linkedList.InsertRecord("Dilip Singh", 82000);
            linkedList.InsertRecord("Vinit Hinge", 62000);
            linkedList.InsertRecord("Tushar Mahadik", 32000);

            Console.WriteLine("Welcome To Bank Cash Counter");
            int wantToContinue = 1;
            while (wantToContinue!=0)
            {
                Console.WriteLine("Enter your Choice:");
                Console.WriteLine("1.Cash Deposite");
                Console.WriteLine("2.Cash Withdrawal");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BankingSimulation.CashDeposite(linkedList);
                        break;

                    case 2:
                        BankingSimulation.CashWithdrawal(linkedList);
                        break;

                    default:
                        Console.WriteLine("Please Enter Valid Choice");
                        break;
                }
                Console.WriteLine("Do you want to conitinue:?? 1/0");
                wantToContinue = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
