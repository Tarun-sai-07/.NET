class Employee
{
	public int Eid{get;set;}
	public string Ename{set;get;}
}
class program
{
	public static void Main()
	{
		Employee e;
		e=new Employee();
		e.Eid=1001;
		e.Ename="ramu";
		System.Console.WriteLine("{0} {1}",e.Eid, e.Ename);
	}
}
		