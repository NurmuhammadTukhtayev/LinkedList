using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTutorial
{
    internal class LinkedList
    {
        public int count;
        public LinkedListNode head;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        // add node in front
        public void AddFront(string data)
        {
            // create a node
            LinkedListNode node = new LinkedListNode(data);

            // add node in front
            node.next = head;

            // set a head
            head = node;

            // increment count
            count++;
        }

        // add node at the end
        public void AddBack(string data)
        {
            if(head == null)
                head = new LinkedListNode(data);
            else
            {

                // create a node
                LinkedListNode node = new LinkedListNode(data);

                // runner for help
                LinkedListNode runner = head;

                // get lastest node
                while (runner.next != null)
                {
                    runner = runner.next;
                }

                // add at end
                runner.next = node;
            }

            // increment count
            count++;
        }

        // add with index
        public void AddWithIndex(int i, string data)
        {
            LinkedListNode node = new LinkedListNode(data);

            // runner for help
            LinkedListNode runner = head;

            int check = 1;

            while(check < i - 1)
            {
                runner = runner.next;
                check++;
            }

            LinkedListNode val = new LinkedListNode(data);
            val.next = runner.next;
            runner.next = val;
        }
        
        // delete first val
        public void DeleteFront()
        {
            if(head == null)
                return;
            head = head.next;

            count--;
        }

        // delete last val
        public void DeleteLast()
        {
            if(head == null)
                return ;

            if(head.next == null)
                head = null;

            else
            {
                LinkedListNode node = head;

                while(node.next.next != null)
                {
                    node = node.next;
                }

                node.next = null;
                count--;
            }
            
        }

        // delete with index
        public void DeleteWithIndex(int index)
        {
            if (index == 1) {
                DeleteFront();
                return ;
            }
            if( index == count)
            {
                DeleteLast();
                return ;
            }

            int counter = 1;

            LinkedListNode node = head;

            while(counter < index - 1 )
            {
                node = node.next;
                counter++;
            }

            node.next = node.next.next;

            count--;
        }

        // delete with value
        public void DeleteWithVaL(string data)
        {
            if (head == null)
                return;

            LinkedListNode node = head;

            int c = 1;

            while(node != null)
            {
                if (node.data == data)
                    break;

                node = node.next;
                c++;
            }

            if (node == null)
                return;

            DeleteWithIndex(c);

        }
    }
}
