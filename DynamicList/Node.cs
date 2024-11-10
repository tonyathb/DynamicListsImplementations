using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    public class Node
    {
        private object element;
        public object Element
        {
            get { return this.element; }
            set { this.element = value; }
        }//za stojnosti

        private Node next;
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }//adresa kym drug element

        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node(object element)
        {
            this.element = element;
            next = null;
        }
    }
}
