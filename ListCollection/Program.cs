
/*
 * List is a Dynamic sized collection Type
 */

//Declare list
using System.ComponentModel;

List<String> names = new List<string>();

String n = string.Empty;

// Add values to list 

while (!n.Equals("-1"))
{
    Console.Write(" Enter Name :");
    n = Console.ReadLine();
    if (!string.IsNullOrEmpty(n) && !n.Equals("-1"))
    {
        names.Add(n);
        Console.WriteLine($"Added {n} successfully");

    }
}

//print list values
Console.WriteLine("Print all values by using for each loop");
foreach (String item in names)
{
        Console.WriteLine(item);
}
 

