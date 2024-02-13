Person person = new Person();
Console.Write("Enter firstName :");
person.FirstName = Console.ReadLine();
Console.Write("Enter lastName :");
person.LastName = Console.ReadLine();
Console.Write("Enter age :");
person.Age = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter salary :");
int sal;
sal = Convert.ToInt32(Console.ReadLine());
person.setsalary(sal);
string middleName = string.Empty;
Console.WriteLine("Enter your middlename");
middleName = Console.ReadLine();
if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Your fullName is : " +person.getfullname());
}
else
{
    Console.WriteLine("Your fullName is : " + person.getfullname(middleName));

}
//Console.WriteLine("Your first name is : " +person.FirstName );
//Console.WriteLine("Your last name is : " +person.LastName );
//Console.WriteLine("Your full_name is :" + person.getfullname());
Console.WriteLine("your age is : " +person.Age);
Console.WriteLine("your salary is :" +person.getsalary());

//calling static class
Console.WriteLine("checking current date is :" + DateTime.Now); //12-02-2024 13:38:17
Console.WriteLine("current date is :" + DateUtil.presentdate()); //:12-02-2024 13:39:43
Console.WriteLine("Year of birth is :" + DateUtil.YearOfBirth(person.Age));
Console.WriteLine("Year of birth is by passing date arug :" + DateUtil.YearOfBirth(new DateTime(1996,07,18)));