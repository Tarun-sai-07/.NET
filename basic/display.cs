class program
{
    public static void Main()
    {
        Items items = new Items();
	items.hlo();
        items.Add(100);
        items.Add(200);
        items.Add(300);
        items.Add(400);
        items.print();
    }
}
class Items
{
	private int []a;
	private int i=0;
	public void hlo()
	{
		a=new int[5];
	}
	public void Add(int value)
	{
		a[i]=value;
		i++;
	}
	public void print()
	{
		for(int i=0;i<4;i++)
		{
			System.Console.WriteLine(a[i]);
		}
	}
}
