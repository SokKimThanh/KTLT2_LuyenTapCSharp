using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.DSArrayList_LinkedList
{
    class MyNode
    {
        internal int value;
        internal MyNode Next;

        public MyNode(int value)
        {
            this.value = value;
            Next = null;
        }
    }
}
