class parent
{
	public parent( int val)
	{
		System.Console.WriteLine("from parent{0}",val);
	}
}
class child:parent
{
	public child(int val):base(val)
	{
		System.Console.WriteLine("from child{0}",val);
	}
}
class program
{
	public static void Main()
	{
		
		parent p=new parent(100);
		child c=new child(200);
	}
}