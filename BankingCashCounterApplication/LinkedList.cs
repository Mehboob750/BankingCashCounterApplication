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
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            return false;
        }

        //To insert the data in LinkedList 
        public Node InsertData(string name, double cash)
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

        //To check the Customer is present or not
        public bool CheckCustomer(string name)
        {
            Node firstPosition = head;
            if (head.name == name)
                return true;
            else
            {
                while (firstPosition != null)
                {
                    if (firstPosition.name == name)
                        return true;
                    firstPosition = firstPosition.next;
                }
            }
            return false;
        }

        //To remove the data from front
        public Node RemoveRecord()
        {
            Node firstPosition = head;
            Node secondPosition = firstPosition.next;
            head = secondPosition;
            head.next = secondPosition.next;
            return head;
        }

        //To print the element of linkedList
        public void DisplayAllRecords()
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
