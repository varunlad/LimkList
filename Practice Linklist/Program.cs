using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            //UC2 insert front
            customLinkedList.InsertFront(56);
            customLinkedList.InsertFront(30);
            customLinkedList.InsertFront(70);

            Console.ReadLine();
        }
    }
}
