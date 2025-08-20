class product 
{
	private int id;
	private string name;
	private double price;

	public int getId() 
	{
		return id;
	}

	public void read()
	{
		id = int.Parse(System.Console.ReadLine());
		name = System.Console.ReadLine();
		price = double.Parse(System.Console.ReadLine());
	}

	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}", id, name, price);
	}
}

class program
{
	public static void Main()
	{
	
		product p1, p2;
		Items item = new Items(2);
		p1 = new product();
		p2 = new product();
		p1.read();
		p2.read();
		item.add(p1);
		item.add(p2);
		System.Console.WriteLine("Enter id to find:");
		int fid = int.Parse(System.Console.ReadLine());
		product t= item.find(fid);
		if (t!= null)
			t.print();
		else
			System.Console.WriteLine("Product not found");
	}
}

class Items
{
	private product[] a;
	private int i = 0;
	private int j=0;
	public Items(int size)
	{
		a = new product[size];
	}

	public void add(product p)
	{
		a[i] = p;
		i++;
	}

	public product get()
	{
		return (a[--i]);
	}

	public product find(int id)
	{
		for ( j = 0; j < i; j++)
		{
			if (a[j].getId() == id)
				return a[j];
		}
		return null;
	}
}
