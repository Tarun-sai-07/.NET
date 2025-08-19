class program
	{
	public static void Main()
	{
		Items items=new Items();
		System.Console.WriteLine("enter the no.of input");
		int find,input=int.Parse(System.Console.ReadLine());
		
		items.create(input);
		items.Add(100);
		items.Add(200);
		items.Add(300);
		items.Add(400);
		items.print();
		find=items.finds(300);
		System.Console.WriteLine(find);
	}
}
class Items
{
	private int []a;
	private int i=0;
	private int k=0;
	public void create(int Size)	
	{	
		a=new int[Size];
	}
	public void create()	
	{	
		a=new int[10];
	}
	public void Add(int value)
	{
		a[i]=value;
		i++;
	}
	public void print()
	{
		for(k=0;k<i;k++)
		{
		System.Console.WriteLine(a[k]);
		}
	}
	public int finds(int find)
	{
		for(k=0;k<i;k++)
		{
			if(find==a[k])
			{
				return k;
			}
		
		}
		return -1;
	}
}