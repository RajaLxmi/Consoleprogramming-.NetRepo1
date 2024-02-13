

//// STRING MANIPULATION FUNCTIONS

string firstName = "first";
string lastName = "last";

//print the string
Console.WriteLine("print the string ---Concept---");
Console.WriteLine("print string");
//concatenation
Console.WriteLine("concatenation ---Concept---");
Console.WriteLine("My full name is " + firstName + ", " + lastName);
Console.WriteLine($"My full name is {firstName}, {lastName}");
Console.WriteLine("My full name is {0}, {1}", firstName, lastName);
//string length
Console.WriteLine("string length ---Concept---");
int length = firstName.Length;
Console.WriteLine($"your name has {length} letters");
//replace string parts
Console.WriteLine("replace string parts ---Concept---");
string newName = firstName.Replace('F', 'K');
Console.WriteLine($"your newName is : {newName}");
//Append to other string variable
Console.WriteLine("Append to other string variable ---Concept---");
string fullName = firstName + lastName;
Console.WriteLine($"your fullName is : {fullName}");

//split string
Console.WriteLine("split string ---Concept---");
string[] splitName = fullName.Split('r');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// compare string

string nullString = null;
string emptyString = ""; // string.Empty;
string whiteSpaceString = " ";

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("string is null");
}

if (firstname == lastname)
{
    Console.WriteLine("name are equal");
}

if (firstname != lastname)
{
    Console.WriteLine("names are not equal");
}

// convert to string

string area = "Ongole";
int number = 1583749860;

area = number.ToString(); // converting int to string by using tostring()
Console.WriteLine(area);
