class linkedlist<T>
{
	private class node
	{
		public T data;
		public node next;
		
		public node(T val)
		
		{
			data =val;
			next =null;
		}
	}
	
	private node first, last;
	public linkedlist()
	{
		first=null;
		last=null;

	}
	
	public void insert(T val)
	{
		node newnode=new node(val);
		if(first ==null)
		{
			first=last=newnode;
		}
		else
		{
			last.next=newnode;
			last=newnode;
		}
	}
	public T get()
	{
				
			T val = first.data;
			first = first.next;
			return val;
		
	}
	public bool isempty()
	{
		return first == null;
	}
}

class lap
{
	public static void Main()
	{


		linkedlist<int> l=new linkedlist<int>();
		l.insert(100);
		l.insert(200);
		l.insert(350);
		l.insert(450);
		l.insert(550);
		while(!l.isempty())
		{
			System.Console.WriteLine(l.get());

		}
	}
}