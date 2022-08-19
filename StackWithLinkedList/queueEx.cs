using System.Threading.Tasks;

namespace StackWithLinkedList
{
    public class QueueEx
    {
        Node rear;
        Node front;

        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear = rear.Next;
            }
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine(" "+temp.data+" ");
                temp = temp.Next;
            }
        }

 
    }
}
