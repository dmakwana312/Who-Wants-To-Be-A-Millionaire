using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    public class LinkedListNode
    {

        // Attributes for current prize and whether is a checkpoint
        private Button prize;
        private Boolean checkpoint;

        // Next node in the linked list
        private LinkedListNode next = null;

        // Constructor without next node attribute
        public LinkedListNode(Button prize, Boolean checkpoint)
        {
            this.prize = prize;
            this.checkpoint = checkpoint;

        }

        // Return prize
        public Button getPrize()
        {
            return this.prize;
        }

        // Return checkpoint
        public Boolean getCheckpoint()
        {
            return this.checkpoint;
        }

        // Return next node
        public LinkedListNode getNext()
        {
            return this.next;
        }

        public void setNext(LinkedListNode next)
        {
            this.next = next;
        }

        public void resetBackground()
        {
            if (this.checkpoint)
            {
                this.prize.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\checkpoint.png");
            }
            else
            {
                this.prize.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\button.png");

            }

        }

        public void setPrizeBackground()
        {
            this.prize.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\prize.png");

        }

        public void setWrongBackground()
        {
            this.prize.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\wrong.png");

        }

    }
}
