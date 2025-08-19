class c2
{
	public static void Main()
	{
		int []x;
		int a,n ,i;
		n=int.Parse(System.Console.ReadLine());
		x=new int [n];
		for( i=0;i<n;i++)
		{	
			x[i]=int.Parse(System.Console.ReadLine());
		}
		
		System.Console.WriteLine("Enter value to search");
		a=int.Parse(System.Console.ReadLine());
		
		for( i=0;i<n;i++)
		{
			if(x[i]==a)
			{
				System.Console.WriteLine("value found");
				break;
			}
		}
			if(i==x.Length)
			{

				System.Console.WriteLine("value not found");

			}
	}
}