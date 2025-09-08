class student
{
    private int sid;
    private string sname;
    public int Sid
    {
        get { 
		return (sid);
		 }
        set { 
		sid = value;
	 }
    }

    public string Sname
    {
        get {	
		 return( sname);
	 }
        set { 
		sname = value;
	 }
    }
}

class program
{
    public static void Main()
    {
        student s = new student();
        s.Sid = 1001;
        s.Sname = "ravi";
        System.Console.WriteLine("{0} {1}", s.Sid, s.Sname);
    }
}
