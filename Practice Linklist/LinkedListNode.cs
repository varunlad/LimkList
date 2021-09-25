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
                this.head = new_node; //pointing Head position to new Node
            }
            else
            {
                Node lastNode = GetLastNode(); //calling GetLastNode Method to get Last Node  
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
    }
}
