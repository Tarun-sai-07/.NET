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
		base.print();
	}
}
class program
{
	public static void Main()
	{
		child c;
		c=new child();
		c.print();
	}
}