using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Linklist
{
    class CustomLinkedList
    {
        public Node head;
        public void InsertLast(int new_data)
        {

            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted Last into list " + new_node.data);

        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public int DeleteFirstNode()
        {
            if (this.head == null) //Checking if my head is null or not 
            {
                return 0;          //For null return 0
            }
            int deleteNode = this.head.data; //if its not null then delet the first node
            this.head = this.head.next;  //Assigning Head to next Node
            return deleteNode;
        }
        public void Display() //Display the LinkList
        {
            Console.WriteLine("Displaying Nodes ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
               
            }

        }
    }
}
