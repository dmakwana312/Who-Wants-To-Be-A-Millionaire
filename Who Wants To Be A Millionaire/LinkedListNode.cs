﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    class LinkedListNode
    {

        // Attributes for current prize and whether is a checkpoint
        private Button prize;
        private Boolean checkpoint;

        // Next node in the linked list
        private LinkedListNode next = null;

        // Constructor with next node attribute
        public LinkedListNode(Button prize, Boolean checkpoint, LinkedListNode next)
        {
            this.prize = prize;
            this.checkpoint = checkpoint;
            this.next = next;
        }

        // Constructor without next node attribute
        public LinkedListNode(Button prize, Boolean checkpoint)
        {
            this.prize = prize;
            this.checkpoint = checkpoint;

        }
    }
}
