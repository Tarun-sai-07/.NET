using System;
using System.Collections;

class phonebook
{
    private string Phno;
    private string Name;
    private string Address;

    public phonebook(string phno, string name, string address)
    {
        this.Phno = phno;
        this.Name = name;
        this.Address = address;
    }

    public void Display()
    {
        System.Console.WriteLine("Phone Number: " + Phno);
        System.Console.WriteLine("Name        : " + Name);
        System.Console.WriteLine("Address     : " + Address);
        
    }
}

class Program
{
    static void Main()
    {
        Hashtable ht = new Hashtable();

       
        phonebook p1 = new phonebook("9885384678", "Ankith", "Hyderabad");
        phonebook p2 = new phonebook("9125987765", "Babu", "Delhi");
        phonebook p3 = new phonebook("9012345678", "Charulatha", "Mumbai");

        ht.Add("Ankith".ToLower(), p1);
        ht.Add("Babu".ToLower(), p2);
        ht.Add("Charulatha".ToLower(), p3);
        
        System.Console.Write("Enter name to search: ");
        string key = System.Console.ReadLine().ToLower();

        if (ht.ContainsKey(key))
        {
            System.Console.WriteLine("\nContact Details:");
            phonebook pb = (phonebook)ht[key];
            pb.Display();
        }
        else
        {
            System.Console.WriteLine("Contact not found.");
        }

        
        System.Console.WriteLine("\nAll Contacts:");
        foreach (DictionaryEntry entry in ht)
        {
            System.Console.WriteLine("Key: " + entry.Key);
            phonebook pb = (phonebook)entry.Value;
            pb.Display();
        }
    }
}
