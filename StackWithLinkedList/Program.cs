using System;
using System.Collections;

namespace StackWithLinkedList
{
    public class Program
    {


        public static void Main(string[] args)
        {
            Stack_Ex stackobj = new Stack_Ex();
            stackobj.Push(20);
            stackobj.Push(30);
            stackobj.Push(40);
            stackobj.Display();
            //stackobj.pop();
            //stackobj.Display();


        }
    }
}