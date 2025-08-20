class parent
{
	public void print()
	{
		System.Console.WriteLine("from parent print");
	}
}
class child:parent
{
	public void print()
	{
		System.Console.WriteLine("from child print");
	}
}
class program
{
	public static void Main()
	{
		parent p;
		child c;
		p=new parent();
		c=new child();
		p.print();
		c.print();
	}
}