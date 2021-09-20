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
        public void InsertFront(int new_data)
        {
            ///We will create a new node. The next of the new node will point to the head of the Linked list.
            Node new_node = new Node(new_data);
            /// When we want to add any node at the front, we want the head to point to it.
            new_node.next = this.head;
            ///The previous Head node is now the second node of Linked List because the new node is added at the front.
            this.head = new_node;
            Console.WriteLine("inserted Front into list " + new_node.data);
        }
    }
}
