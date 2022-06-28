using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Stack
    {
        //Creating node a top
        public Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        //added value in stack
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value into stack " + temp.data);
                temp = temp.next;
            }
        }
    }
}
