class Collection 
{
	private object []x;
	public Collection(int ndx)
	{
		x=new object[ndx];
	}
	public void Add(object value)
	{
		x[count++]=value;
	}
	public int count{get;set;}
	public object this[int ndx]
	{
		get
		{
			return x[ndx];
		}
	}
}
class List
{
	private Collection C;
	public List(int size)
	{
		C=new Collection(size);
	}
	public List()
	{
		C=new Collection(10);
	}
	public Collection Items
	{
		get
		{
			return(C);
		}
	}
}
class program
{
	public static void Main()
	{
		List l=new List();
		l.Items.Add(100);
		l.Items.Add(200);
		l.Items.Add(300);
		l.Items.Add(400);
		for(int i=0;i<l.Items.count;i++)
		{
			System.Console.WriteLine(l.Items[i]);
		}
	}
}