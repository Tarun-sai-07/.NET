class c2
{
	public static void Main()
	{
		int [,] x,y;
		x=new int[2,2];
		y=new int[2,2];
		for(int i=0;i<x.GetLength(0);i++)
		{
			for(int j=0;j<x.GetLength(1);j++)
			{
				x[i,j]=int.Parse(System.Console.ReadLine());
			}
		}
		for(int i=0;i<y.GetLength(0);i++)
		{
			for(int j=0;j<y.GetLength(1);j++)
			{
				y[i,j]=int.Parse(System.Console.ReadLine());
			}
		}
		for(int i=0;i<x.GetLength(0);i++)
		{
			for(int j=0;j<y.GetLength(1);j++)
			{
				
		
				System.Console.WriteLine(x[i,j]+y[i,j]);
			}

		}
	}
}