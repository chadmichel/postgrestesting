// See https://aka.ms/new-console-template for more information

using System;
using PostgresSampleApp;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        
        var db = new TestDatabase();
        db.Contacts.Add(new Contact()
        {
            Name = "hi"
        });
        db.SaveChanges();
        
        Console.WriteLine("Bye, World!");
    }
}
