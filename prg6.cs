class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter the number of inputs:");
        int input = int.Parse(System.Console.ReadLine());
        Items items = new Items(input);

        items.Add(100);
        items.Add(200);
        items.Add(300);
        items.Add(400);
	items.Add(500);
	items.Add(600);
        items.Print();
    }
}

class Items
{
    private int[] a;
    private int i = 0; 
    public Items(int size)
    {
        a = new int[size];
    }

    	    public Items()
    {
        a = new int[10];
    }

    public void Add(int value)
    {
        a[i] = value;
        i++;
    }

    public void Print()
    {
        for (int k = 0; k < i; k++)
        {
            System.Console.WriteLine(a[k]);
        }
    }
}
