using System;

namespace KTLT2_TAODOITUONG.src.DSArrayList_LinkedList
{
    class Submenu_LinkedList
    {

        public void GetSubMenu()
        {
            MyLinkedList l = new MyLinkedList();

            MyNode m1 = l.AddFirst(1);
            MyNode m2 = l.AddFirst(2);
            MyNode m3 = l.AddFirst(3);
            Console.WriteLine(l.printList());
            Console.WriteLine("/first: " + l.First.value + "/last: " + l.Last.value + "/count: " + l.Count+ "\n");

            MyNode m4 = l.AddLast(1);
            MyNode m5 = l.AddLast(2);
            MyNode m6 = l.AddLast(3);
            Console.WriteLine(l.printList());
            Console.WriteLine("/first: " + l.First.value + "/last: " + l.Last.value + "/count: " + l.Count + "\n");

            MyNode m7 = l.addAfter(m1, 4);
            MyNode m8 = l.addAfter(m2, 5);
            MyNode m9 = l.addAfter(m3, 6);
            Console.WriteLine(l.printList());
            Console.WriteLine("/first: " + l.First.value + "/last: " + l.Last.value + "/count: " + l.Count + "\n");


            MyNode m10 = l.addBefore(m1, 4);
            MyNode m11 = l.addBefore(m2, 5);
            MyNode m12 = l.addBefore(m3, 6);
            Console.WriteLine(l.printList());
            Console.WriteLine("/first: " + l.First.value + "/last: " + l.Last.value + "/count: " + l.Count + "\n");
            Console.WriteLine("press any key to back");
            Console.ReadKey();
        }
    }
}
