abstract class Amath
{
	public abstract int sum(int x,int y);
	public int mult(int x,int y)
	{
		return(x*y);
	}
}
class Math:Amath
{
	public override int sum(int x,int y)
	{
		return(x+y);
	}
	public int div(int x,int y)
	{
		return(x/y);
	}
}
class program
{
	public static void Main()
	{
		Amath m;
		Math math=new Math();
		System.Console.WriteLine(math.sum(100,200));
		System.Console.WriteLine(math.div(50,10));
		System.Console.WriteLine(math.mult(50,2));
		
		m=new Math();
		System.Console.WriteLine(m.sum(100,200));
		System.Console.WriteLine(m.mult(50,2));
		System.Console.WriteLine((m as Math).div(50,10));
	}
}