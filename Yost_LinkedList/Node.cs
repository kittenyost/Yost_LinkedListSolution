using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yost_LinkedList
{
    internal class Node
    {

        public string Data;
        public Node Next;
        public Node()
        {

        }
        public Node(string data)
        {
            Data = data;
        }

        public Node(string data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}

