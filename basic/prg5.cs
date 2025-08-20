class student
{

	private int sno;
	private string sname;
	private double fee;

	public void Read()
	{
		
		System.Console.WriteLine("enter student no");
		sno=int.Parse(System.Console.ReadLine());

		
		System.Console.WriteLine("enter student name");
		sname=System.Console.ReadLine();

		System.Console.WriteLine("enter fee");
		fee=double.Parse(System.Console.ReadLine());
	
	}
	
	public void Print()
	{
		System.Console.WriteLine("{0} {1} {2} ",sno,sname,fee);
	}
	public int id()
	{
		return (sno);
	}
}
	
class prg
{

	public static void Main()
	{
		int i;
		student []s;
		s=new student[5];
		
		for( i=0;i<5;i++)
		{
			s[i]=new student();
			s[i].Read();
		}

		System.Console.WriteLine("Enter the student no to search");
		int searchno = int.Parse(System.Console.ReadLine());
		
		for( i=0;i<5;i++)
		{
			if(s[i].id()==searchno)
			{
				System.Console.WriteLine("student found");
				s[i].Print();
				break;
				
			}
		}
		if(i==5)
		{
			System.Console.WriteLine("student not found");
		}
	}
}
