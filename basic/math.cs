class Math
{
    private  int data;

    public Math(int val)
    {
        data = val;
    }

    public Math Sum(Math m)
    {
        Math t;
	t = new Math(data + m.data);
        return (t);
    }

    public void Print()
    {
        System.Console.WriteLine(data);
    }
}

class Program
{
    public static void Main(string[] a)
    {
        Math m1 = new Math(50);
        Math m2 = new Math(200);
        Math m3 = m1.Sum(m2);
	System.Console.WriteLine("TOTAL");
        m3.Print();
    }
}