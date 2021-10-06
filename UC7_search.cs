using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Linked_List_Assign
{
    class UC7_search
    {
        internal Node head; //new
        internal void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list\n", node.data);
        }

        internal Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("your element found");
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }

        }
    }


