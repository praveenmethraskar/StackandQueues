using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLinkedList
{
    public class Stack_Ex
    {

        Node top;

        public Stack_Ex()
        {
            top = null;
        }

        public void Push(int  data)
        {
            Node newnode = new Node(data);
            newnode.Next = top;
            top = newnode;

        }

        public void Display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node temp = top;
            while(temp != null)
            {
                Console.WriteLine(" "+temp.data+" ");
                temp = temp.Next;
            }
        }
        public void peek()
        {
            // check for empty stack 
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node temp = top;
            Console.WriteLine(temp.data+ " is top element");
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            this.top = this.top.Next;
        }


    }
}
