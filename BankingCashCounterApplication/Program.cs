﻿using System;

namespace BankingCashCounterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Banking Cash Counter");
            LinkedList linkedList = new LinkedList();
            linkedList.insertData("Akshay Kumar", 35000);
            linkedList.insertData("Rahul Roy", 2000);
            Console.WriteLine(linkedList.isEmpty());
        }
    }
}
