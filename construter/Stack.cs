class Stack
{
	
	private int []s;
	int i;
	public Stack(int val)
	{
		s=new int[val];
	}
	public void push(int value)
	{
			s[i]=value;
			i++;
	}	
	public int pop()
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
		Stack s=new Stack(10);
		s.push(100);
		s.push(200);
		s.push(300);
		s.push(400);
		s.push(500);
		while(!(s.isEmpty()))
		{
				r=s.pop();
				System.Console.WriteLine(r);

		}
	}
}