using System;
using System.Collections;

namespace StackWithLinkedList
{
    public class Program
    {


        public static void Main(string[] args)
        {
            //Stack_Ex stackobj = new Stack_Ex();
            //stackobj.Push(20);
            //stackobj.Push(30);
            //stackobj.Push(40);
            //stackobj.Display();
            //stackobj.peek();
            //stackobj.pop();
            //stackobj.Display();

            //stackobj.peek();
            //stackobj.pop();
            //stackobj.Display();

            //stackobj.peek();
            //stackobj.pop();
            //stackobj.Display();


            QueueEx queueEx = new QueueEx();
            queueEx.Enqueue(56);
            queueEx.Enqueue(30);
            queueEx.Enqueue(70); 
            queueEx.Display();

            queueEx.Dequeue();
            queueEx.Display();

        }
    }
}