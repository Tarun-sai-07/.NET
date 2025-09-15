class collection
{
	private object []x;
	public collection(int ndx)
	{
		x=new object[ndx];
	}
	public collection()
	{
		x=new object[10];
	}
	public void add(object value)
	{
		x[count++]=value;
	}
	public int count{get;set;}
	public object this[int ndx]
	{
		
		get
		{
			for(int i=0;i<count;i++)
			{ 
				product p = x[i] as product;
				
                		if (p != null && p.Pid == ndx)
                		{
					
                  	  		return x[i];
               			}
			}
			return null;
		}
	}
	public object this[string ndx]
	{
		
		get
		{
			for(int i=0;i<count;i++)
			{ 
				product p = x[i] as product;
				
                		if (p != null && p.Pname.Equals(ndx))
                		{
					
                  	  		return x[i];
               			}
			}
			return null;
		}
	}
}
class list
{
	private collection c;
	public list(int size)
	{
		c=new collection(size);
	}
	public list()
	{	
		c=new collection(10);
	}
	public collection items
	{
		get
		{
			return (c);
		}
	}
}
class program
{
    public static void Main()
    {
        int r;
        list l = new list();
        product p1 = new product();
        product p2 = new product();
        product p3 = new product();
        product p4 = new product();
        p1.read();
        p2.read();
        p3.read();
        p4.read();
    	l.items.add(p1);
        l.items.add(p2);
        l.items.add(p3);
        l.items.add(p4);
        System.Console.WriteLine("ENTER PRODUCT ID TO FIND:");
        r = int.Parse(System.Console.ReadLine());
	product t = (product)l.items[r];
         if (t != null)
        {
            System.Console.WriteLine("FOUND:");
            t.print();
        }
        else
        {
            System.Console.WriteLine("NOT FOUND");
        }
    }
}

class product
{
	private int pid;
	private string pname;
	private double price;
	public int Pid
    	{
        	get 
		{ 
			return pid;
		}
        	set
		{ 
			pid = value; 
		}
    	}

    	public string Pname
    	{
    	    	get 
		{ 
			return pname; 
		}
    	    	set 
		{ 
			pname = value; 
		}
    	}

    	public double Price
    	{
        	get
		{ 
			return price;
		}
        	set 
		{ 
			price = value; 
		}
    	}
	public void read()
	{
		pid=int.Parse(System.Console.ReadLine());
		pname=System.Console.ReadLine();
		price=double.Parse(System.Console.ReadLine());
	}
	public void print()
	{
		System.Console.WriteLine("{0} {1} {2}",pid,pname,price);
	}
}