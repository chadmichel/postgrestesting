using System;
using NUnit.Framework;
using PostgresSampleApp;

namespace UnitTestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        Console.WriteLine("Hello, World!");
        
        var db = new TestDatabase();
        db.Database.EnsureCreated();
        db.Contacts.Add(new Contact()
        {
            Name = "hi"
        });
        db.SaveChanges();
        
        Console.WriteLine("Bye, World!");
    }
}