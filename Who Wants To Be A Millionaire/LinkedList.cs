﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_Wants_To_Be_A_Millionaire
{
    class LinkedList
    {

        // Head of the list
        private LinkedListNode head;

        // Constructor
        public LinkedList()
        {
            this.head = null;

        }

        // Add Node To End of List
        public void addToList(LinkedListNode next)
        {
            if(head == null)
            {
                head = next;
            }
            else
            {

                LinkedListNode node = head;
                while (node.getNext() != null)
                {
                    node = node.getNext();
                }

                node.setNext(next);
            }
        }
    }
}
