class c2
{
    
    public static void swap( ref int a, ref int b)
    {
        int c ;
	c = a;
        a = b;
        b = c;
	
    }

    public static void Main()
    {
        int a, b;

        
        System.Console.WriteLine("Enter first value:");
        a= int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Enter second value:");
        b = int.Parse(System.Console.ReadLine());

   	swap( ref a,ref b);
	System.Console.WriteLine("{0} {1}",a,b);

    }
}
