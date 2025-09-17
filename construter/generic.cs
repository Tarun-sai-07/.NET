class Generic <T>
{
	T data;
	public void setdata(T value)
	{
		data=value;
	}
	public T getdata()
	{
		return(data);
	}
}
class program
{
	public static void Main()
	{
		Generic <int> Gi;
		Generic <string> Gs;
		Gi =new Generic<int>();
		Gs =new Generic<string>();
		Gi.setdata(100);
		Gs.setdata("HARI");
		System.Console.WriteLine(Gs.getdata());
		System.Console.WriteLine(Gi.getdata());
	}
}