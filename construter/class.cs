class product : bases
{
	private int pid;
	private string pname;
	private double price;
	public void read()
	{
		pid=int.Parse(System.Console.ReadLine());
		pname=System.Console.ReadLine();
		price=double.Parse(System.Console.ReadLine());
	}
	public override void print()
	{
		System.Console.WriteLine(" {0} {1} {2}",pid,pname,price);
	}
}
class employee : bases
{
	private int eid;
	private string ename;
	private double salary;
	public void read()
	{
		eid=int.Parse(System.Console.ReadLine());
		ename=System.Console.ReadLine();
		salary=double.Parse(System.Console.ReadLine());
	}
	public override void print()
	{
		System.Console.WriteLine("{0} {1} {2}",eid,ename,salary);
	}
}
class bases
{

	public virtual void print()
	{
	}
}
class program
{
	public static void Main()
	{
		Items item=new Items(2);
		product p=new product();
		employee e=new employee();
		p.read();
		e.read();
		item.Add(p);
		item.Add(e);
		for(int i=0;i<2;i++)
		{
			item.get().print();
		}
	}
}
class Items
{
	private bases []a;
	int i;
	public Items(int size)
	{
		a=new bases[size];
	}
	public void Add(bases p)
	{
		a[i]=p;
		i++;
	}
	public bases get()
	{
		return(a[--i]);
	}
}