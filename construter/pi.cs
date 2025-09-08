class Items
{
	private int[]x;
	public Items()
	{
		x=new int[10];
	}
	public int this[int ndx]
	{
		set{
			x[ndx]=value;
		 }
		get{
			return x[ndx];
		}
	}
}
class program
{
	public static void Main()
	{
		Items items;
		items=new Items();
		items[0]=100;
		items[1]=200;
		for(int i=0;i<2;i++)
		{
			System.Console.WriteLine(items[i]);
		}
	}
}
		
		