using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Linked_List_Assign
{
    class UC5_delete_first
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

        internal Node pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                //Console.WriteLine("->");
                temp = temp.next; //temp=null
            }

        }
    }
}
