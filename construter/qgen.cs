class Queue<T>
{
	private T []Q;
	
	int front = 0;
	int rear=0;
	public Queue(int size)
	{
		Q=new T[size];
	}
	public void enqueue(T val)
	{
		Q[rear]=val;
		rear++;
		
	}
	
	public T dequeue()
	{
		return Q[front++];
	}
	
		
	public bool isempty()
	{
		
		if(front<rear)
			
			return false;
		return true;
	}

	
}	

class lap
{	
	public static void Main()
	{
	
		Queue<int> Q=new Queue<int>(10);
		Queue<string> Qs=new Queue<string>(10);
		Q.enqueue(110);
		Q.enqueue(220);
		Q.enqueue(330);
		Q.enqueue(440);
		Q.enqueue(550);
		Qs.enqueue("ramu");
		Qs.enqueue("tarun");
		Qs.enqueue("madhan");
		Qs.enqueue("krithuka");
		Qs.enqueue("shambala");
		while(!(Q.isempty()))
		{
		
			System.Console.WriteLine(Q.dequeue());
		}
		while(!(Qs.isempty()))
		{
		
			System.Console.WriteLine(Qs.dequeue());
		}
	}
}
