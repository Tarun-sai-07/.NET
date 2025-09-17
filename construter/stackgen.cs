class Stack<T>
{
	
	private T []s;
	int i;
	public Stack(int val)
	{
		s=new T[val];
	}
	public void push(T value)
	{
			s[i]=value;
			i++;
	}	
	public T pop()
	{
		return s[i--];
	}
	public bool isEmpty()
	{
		if(i>=0)
			return false;
		return true;
	}
}
class program
{
	public static void Main()
	{
		int r;
		Stack<int> s=new Stack<int>(10);
		Stack<string> ss=new Stack<string>(10);
		s.push(101);
		s.push(202);
		s.push(303);
		s.push(404);
		s.push(505);
		ss.push("kiran");
		ss.push("jackie");
		ss.push("ravi");
		ss.push("ramu");
		ss.push("sai");
		
		while(!(s.isEmpty()))
		{
				
				r=s.pop();
				System.Console.WriteLine(r);

		}
		
		while(!(ss.isEmpty()))
		{
				
				System.Console.WriteLine(ss.pop());

		}
	}
}
