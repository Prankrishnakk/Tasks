using System;
using System.Collections.Generic;
using System.Linq;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {

        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30, City = "New York" },
            new Person { Name = "Bob", Age = 22, City = "Los Angeles" },
            new Person { Name = "Charlie", Age = 27, City = "New York" },
            new Person { Name = "David", Age = 35, City = "Chicago" },
            new Person { Name = "Emma", Age = 29, City = "New York" }
        };

        var filteredPeople = people
            .Where(p => p.Age > 25 && p.City == "New York")
            .Select(p => new { p.Name, p.Age })
            .ToList();


        Console.WriteLine("People above 25 years old in New York:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
