class Queue<T>
{
    private class Node
    {
        public T data;
        public Node next;

        public Node(T val)
        {
            data = val;
            next = null;
        }
    }
    private Node front, rear;
    public Queue()
    {
        front = rear = null;
    }
    public void Enqueue(T val)
    {
        Node newNode = new Node(val);
        if (IsEmpty())
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            System.Console.WriteLine("Queue Underflow!");
            return default(T);
        }

        T val = front.data;
        front = front.next;
        if (front == null)
        {
            rear = null;
        }

        return val;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            System.Console.WriteLine("Queue is Empty!");
            return default(T);
        }
        return front.data;
    }
    public bool IsEmpty()
    {
        return front == null;
    }
}
class Lap
{
    public static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);
        q.Enqueue(50);
        while (!q.IsEmpty())
        {
            System.Console.WriteLine(q.Dequeue());
        }
    }
}
