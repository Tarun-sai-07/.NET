class parent
{
	public parent()
	{
		System.Console.WriteLine("from parent");
	}
}
class child:parent
{
	public child()
	{
		System.Console.WriteLine("from child");
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
	}
}