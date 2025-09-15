delegate int mydelegate(int x,int y);
class math
{
	public int sum(int x,int y)
	{
		return(x+y);
	}
	public int multi(int x,int y)
	{
		return(x*y);
	}
}
class program
{
	public static void Main()
	{
		math m=new math();
		mydelegate md=new mydelegate(m.sum);
		md+=new mydelegate(m.multi);
		System.Console.WriteLine(md(10,20));
		md-=new mydelegate(m.sum);
		System.Console.WriteLine(md(5,2));
	}
}