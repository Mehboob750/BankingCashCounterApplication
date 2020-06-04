using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BankingCashCounterApplication
{
    //LinkedList DataStructure created to store and Manipulate the Customer Data
    public class LinkedList
    {
        Node head;
        internal static bool checkCustomer;

        public class Node
        {
            public String name;
            public double cash;
            public Node next;

            public Node
                 (string name, double cash)
            {
                this.name = name;
                this.cash = cash;
            }
        }

        //To check the LinkedList is Empty or Not
        public bool isEmpty()
        {
            if (head == null)
                return true;
            return false;
        }

    }
}
