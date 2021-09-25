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
        /// <summary>
        /// Inserts the last.
        /// </summary>
        /// <param name="new_data">The new data.</param>
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
      
        public int getCount()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
<<<<<<< HEAD
                count++;
=======
                if (temp.data == value)  //Checking if my node data is equal to my Searching data or not
                {
                    Console.WriteLine("\nNode is present "); //if it is equal Print the result
                    return value;
                }
>>>>>>> UC7SearchNode
                temp = temp.next;
            }
            return count;
        }
    }
}
