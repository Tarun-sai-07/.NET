class math
{
	public int sum(int x,int y)
	{
		return(x+y);
	}
	public float sum(float x,float y)
	{
		return(x+y);
	}
	public double sum(double x,double y)
	{
		return(x+y);
	}
	public int sum(int x,int y,int z)
	{
		return(x+y+z);
	}
	public int sum(int x,string y)
	{
		return (x+int.parse(y));
	}
	public int sum(string x,int y)
	{
		return(int.parse(x)+y);
	}
	public string sum(string x,string y)
	{
		return (x+y);
	}
}
class program
{
	public static void main()
	{
		math m=new math();
		System.Console.WriteLine(m.sum(100,200));
		System.Console.WriteLine(m.sum(20.22f,50.72f);
		System.Console.WriteLine(m.sum(20.222222,50.4444));
		System.Console.WriteLine(m.sum(100,"200"));
		System.Console.WriteLine(m.sum("100",200));
		System.Console.WriteLine(m.sum(10,20,30));
		System.Console.WriteLine(m.sum("100","200"));
	}
}