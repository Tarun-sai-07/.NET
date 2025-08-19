class product 
{
	private int id;
	private string pname;
	private double prize;
	public void read()
	{
		id=int.Parse(System.Console.ReadLine());
		pname=System.Console.ReadLine();
		prize=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}",id,pname,prize);
	}
}
class program
{
	public static void Main()
	{
		int i;
		product p1,p2;
		Items item=new Items(2);
		p1=new product();
		p2=new product();
		p1.read();
		p2.read();
		item.add(p1);
		item.add(p2);
		for(i=0;i<2;i++)
		{
			product t;
			t=item.get();
			t.print();
		}
	}
}
class Items
{
	private product []a;
	private int i=0;
	
	public Items(int size)
	{
		a=new product[size];
	}
	public void add(product p)
	{
		a[i]=p;
		i++;
	}
	public product get()
	{
		
		return(a[--i]);
		
	}
}