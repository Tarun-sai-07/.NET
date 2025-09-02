class Queue
{
	private int []Q;
	
	int front = 0;
	int rear=0;
	public Queue(int size)
	{
		Q=new int[size];
	}
	public void enqueue(int val)
	{
		Q[rear]=val;
		rear++;
		
	}
	
	public int dequeue()
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
	
		Queue Q=new Queue(10);
		Q.enqueue(10);
		Q.enqueue(20);
		Q.enqueue(30);
		Q.enqueue(40);
		Q.enqueue(50);
		
		while(!(Q.isempty()))
		{
		
			System.Console.WriteLine(Q.dequeue());
		}
	}

		
}