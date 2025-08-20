class math2025
{
    public int sum(int x, int y)
    {
        return (x + y);
    }

    protected int mult(int x, int y)
    {
        return (x * y);
    }

    public int Mult(int x, int y) 
    {
        return mult(x, y);
    }
}

class math2026 : math2025
{
    public int div(int x, int y)
    {
        return (x / y);
    }

    public int multiply(int x, int y)
    {
        return mult(x, y); 
    }
}

class program
{
    public static void Main()
    {
        math2025 m1 = new math2025();
        math2026 m2 = new math2026();

        System.Console.WriteLine(m1.sum(10, 20));
        System.Console.WriteLine(m1.Mult(20, 2)); 
        System.Console.WriteLine(m2.sum(100, 200));  	
        System.Console.WriteLine(m2.multiply(20, 20));
        System.Console.WriteLine(m2.div(50, 2));
        System.Console.WriteLine(m2.multiply(50, 2));
    }
}
