// See https://aka.ms/new-console-template for more information
//


//Variable Decleration and Types
//Camel case (ex: camelCase) is usually for variables.
string fullName = string.Empty; //Assign default values
int age = 0;    
double salary = 0;
char gender = char.MinValue;
bool working;

// Allow user for input
Console.Write(" Enter Your fullName : ");
 fullName = Console.ReadLine();
Console.Write(" Enter Your age : ");
 age = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter Your salary : ");
salary = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter Your gender (F or M)  : ");
gender = Convert.ToChar(Console.ReadLine());
Console.Write("Are you Employed (true or false)  : ");
working = Convert.ToBoolean(Console.ReadLine());


// Print output
Console.WriteLine("Your Full Name is  : " + fullName); // concatenation
Console.WriteLine("Your Age is : {0} ", age);           // place older
Console.WriteLine($"Your Salary is : {salary} ");    //interpolation
Console.WriteLine($"Your gnder is : {gender} ");
Console.WriteLine($"Are you employed  : {working} ");

