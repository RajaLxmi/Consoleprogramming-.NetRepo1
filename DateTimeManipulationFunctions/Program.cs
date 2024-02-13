// See https://aka.ms/new-console-template for more information

// string an int is a primitive data types.
// DateTime is a complex date type would be a combination of different data types.

//Empty DateTime
DateTime date = new DateTime(); // DateTime is a class and here we are initializing the DateTime object

//Create a DateTime from Date and Time 
DateTime dateofbirth = new DateTime(1990, 12, 30);
Console.WriteLine("DateTime from Date and Time : " + dateofbirth);

//Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("DateTime from current timestamp " + now);

//Create a DateTime from a string
DateTime DateTimeString =DateTime.Parse("1/1/2000");
Console.WriteLine("DateTime from String" + DateTimeString);

//Add Aditional Time

Console.WriteLine(" one Hour from now " + now.AddHours(1));
Console.WriteLine(" one Day from now " + now.AddDays(1));

//Ticks from DateTime 
Console.WriteLine(" ticks from now " + now.Ticks);

//Date Only
DateOnly dateOnlyofbirth = DateOnly.FromDateTime(dateofbirth);
Console.WriteLine("Dateonly from dateofbirth :" + dateOnlyofbirth);

//Time Only
TimeOnly timeOnly1 = TimeOnly.FromDateTime(now);
Console.WriteLine("Timeonly from now : " +timeOnly1);
