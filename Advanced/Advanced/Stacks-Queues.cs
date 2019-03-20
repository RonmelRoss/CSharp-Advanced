using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class StacksQueues
    {
        string strStack = "", strQueue = "";
        Stack stack = new Stack();
        Queue queue = new Queue();

        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }
        public void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }
        public string popCharacter()
        {
            foreach (char c in stack)
            {
                strStack += c;
            }
            return strStack;
        }
        public string dequeueCharacter()
        {
            foreach (char c in queue)
            {
                strQueue += c;
            }
            return strQueue;
        }
    }
}
