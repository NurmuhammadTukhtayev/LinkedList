using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial
{
    internal class LinkedListNode
    {
        public string data;
        public LinkedListNode next;

        public LinkedListNode(string x)
        {
            data = x;
            next = null;
        }
    }
}
