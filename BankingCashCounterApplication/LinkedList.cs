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

        //To insert the data in LinkedList 
        public Node insertData(string name, double cash)
        {
            if (name != " " && cash != null && name != null)
            {
                Node newNode = new Node(name, cash);
                newNode.next = null;

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node lastPosition = head;
                    while (lastPosition.next != null)
                    {
                        lastPosition = lastPosition.next;
                    }
                    lastPosition.next = newNode;
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Data");
            }
            return head;
        }

        //To print the element of linkedList
        public void display()
        {
            Node lastPosition = head;
            while (lastPosition != null)
            {
                Console.WriteLine("Name:"+ lastPosition.name + "\t"+"Balance:"+ lastPosition.cash);
                lastPosition = lastPosition.next;
            }
        }
    }
}
