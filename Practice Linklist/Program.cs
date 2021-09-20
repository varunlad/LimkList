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
            //UC3 append
            customLinkedList.Append(56);
            customLinkedList.Append(30);
            customLinkedList.Append(70);
            Console.ReadLine();
        }
    }
}
