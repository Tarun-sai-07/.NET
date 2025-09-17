class Stack<T>
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
    private Node top;
    public Stack()
    {
        top = null;
    }
    public void Push(T val)
    {
        Node newNode = new Node(val);
        newNode.next = top;
        top = newNode;
    }
    public T Pop()
    {
        if (IsEmpty())
        {
            System.Console.WriteLine("Stack Underflow!");
            return default(T);
        }

        T val = top.data;
        top = top.next;
        return val;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            System.Console.WriteLine("Stack is Empty!");
            return default(T);
        }

        return top.data;
    }
    public bool IsEmpty()
    {
        return top == null;
    }
}

class Lap
{
    public static void Main()
    {
        Stack<int> s = new Stack<int>();
        s.Push(101);
        s.Push(202);
        s.Push(303);
        s.Push(404);
        s.Push(505);
        while (!s.IsEmpty())
        {
            System.Console.WriteLine(s.Pop());
        }
    }
}
