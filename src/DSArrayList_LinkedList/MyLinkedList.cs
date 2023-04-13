using System;

namespace KTLT2_TAODOITUONG.src.DSArrayList_LinkedList
{
    class MyLinkedList
    {
        private MyNode first;
        private MyNode last;
        private int count;

        public int Count { get => count; }
        internal MyNode First { get => first; }
        internal MyNode Last { get => last; }


        // them vao dau first
        public MyNode AddFirst(int n)
        {
            MyNode node = new MyNode(n);
            if (first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                node.Next = first;//save first
                first = node;// put into first
            }
            count++;
            return node;
        }
        // them vao sau last
        public MyNode AddLast(int n)
        {
            MyNode node = new MyNode(n);
            if (first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                last.Next = node;//save node
                last = node;// put into last
            }
            count++;
            return node;
        }
        // in
        public string printList()
        {

            //khai bao 
            MyNode p = first;
            string s = "";
            //duyet mang node
            while (p != null)
            {
                s += p.value + " ";
                p = p.Next;
            }
            return s;
        }
        // them vao phia truoc 1 node
        public MyNode addBefore(MyNode preNode, int value)
        {
            MyNode node;
            if (first == null || preNode == first)
            {
                node = AddFirst(value);
            }
            else
            {
                // tao node moi 
                node = new MyNode(value);
                MyNode nodeBefore = FindNodeBefore(preNode);
                if (nodeBefore != null)
                {
                    node.Next = preNode;// save prenode
                    nodeBefore.Next = node;// put in nodebefore
                    count++;
                }
            }
            return node;
        }
        // them vao phia sau 1 node
        public MyNode addAfter(MyNode preNode, int value)
        {
            MyNode node;
            if (first == null || preNode == last)
            {
                node = AddLast(value);
            }
            else
            {
                node = new MyNode(value);
                node.Next = preNode.Next; // save preNode.next;
                preNode.Next = node;// put in preNode.next;
                count++;
            }
            return node;
        }
        public MyNode FindNodeBefore(MyNode preNode)
        {
            MyNode nodeBefore = first;

            while (nodeBefore.Next != preNode)
            {
                nodeBefore = nodeBefore.Next;
            }
            return nodeBefore;
        }
    }
}
