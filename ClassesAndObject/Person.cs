
//object oriented programming has to do is - creating your own datatype it includes properties and methods we do that through the definition of class.

/* For example: in real life, a car is an object. The car has attributes, such as weight and color, and methods, such as drive and brake.
 *  A Class is like an object constructor, or a "blueprint" for creating objects. 
*/



class Person
{
    //Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //Fields
    private double _salary {  get; set; }

    public void setsalary(double salary)
    {
        _salary = salary;
    }

    public double getsalary()
    {
        return _salary;
    }
    public string getfullname()
    { return $"{FirstName} {LastName}"; }

    public string getfullname(string middle_name)
    { return $"{FirstName} {middle_name} {LastName}"; }

}