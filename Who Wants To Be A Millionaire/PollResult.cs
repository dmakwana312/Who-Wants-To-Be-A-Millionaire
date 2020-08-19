using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_Wants_To_Be_A_Millionaire
{
    class PollResult
    {
        private char optionKey;
        private int value;

        public PollResult(String optionKey, int value)
        {
            this.optionKey = Convert.ToChar(optionKey);
            this.value = value;
        }

        public char getoptionKey()
        {
            return this.optionKey;
        }

        public int getValue()
        {
            return this.value;
        }
    }
}
