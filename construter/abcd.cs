using System.Collections;

class program
{
	class product
	{
		public int id { get;set; }
		public string name { get;set; }
	
		public override string ToString()
		{
			return string.Format("{0} {1}",id,name);
		}
	}
	public static void Main()
	{
		ArrayList list=new ArrayList();
		
		ArrayList list2=new ArrayList();
		
		list2.Add(1);
		list2.Add(2);
		
		list.Add(100);
		list.Add("ramu");
		list.Add(20.00);
		list.AddRange(list2);
		
		product p=new product() 	{id=100,name="ganesh"};

		list.Add(p);

		System.Console.WriteLine(list[0]);

		IEnumerator ie=list.GetEnumerator();
		while(ie.MoveNext())
		{
			System.Console.WriteLine(ie.Current);
		}
	
		foreach(object o in list)
		{
			System.Console.WriteLine(o);
		}
		

		//stack
		
		Stack stack=new Stack();
		stack.Push(100);
		stack.Push(200);
		stack.Push(300);
		stack.Push(400);
		
		/*while(stack.Count>0)
		{
			System.Console.WriteLine(stack.Pop());
		}*/

		/* ie=stack.GetEnumerator();
		while(ie.MoveNext())
		{
			System.Console.WriteLine(ie.Current);
		}*/

		foreach(object o in stack)
		{
			System.Console.WriteLine(o);
		
		}

		System.Collections.Generic.Queue<string> q=new System.Collections.Generic.Queue<string>();
		q.Enqueue("karthi");
		q.Enqueue("ravi");
		q.Enqueue("shiva");
		
		foreach(string str in q)
		{
			System.Console.WriteLine(str);
		}

		System.Collections.Generic.LinkedList<string> strings =new System.Collections.Generic.LinkedList<string>();
		strings.AddLast("one");
		strings.AddLast("two");
		strings.AddLast("three");
		
		System.Collections.Generic.IEnumerator<string> gie = strings.GetEnumerator();
		while(gie.MoveNext())
		{
			System.Console.WriteLine(gie.Current);
		}
		System.Console.WriteLine("break");
		System.Collections.Generic.Dictionary<int,string> keyValuePairs = new System.Collections.Generic.Dictionary<int,string >();
		
		keyValuePairs.Add(1,"one");
		keyValuePairs.Add(2,"Two");	
		keyValuePairs.Add(20,"Twenty");
		keyValuePairs.Add(6,"six");
		System.Console.WriteLine("five");
		System.Console.WriteLine(keyValuePairs[20]);
		
		System.Collections.Generic.IEnumerator<int> keys=keyValuePairs.Keys.GetEnumerator();
		while(keys.MoveNext())
		{
			System.Console.WriteLine("{0} {1}",keys.Current,keyValuePairs[keys.Current]);
		}
	
		System.Collections.Generic.IEnumerator<string>  values=keyValuePairs.Values.GetEnumerator();
	
		while(values.MoveNext())
		{
			System.Console.WriteLine(values.Current);
		}
	}
}