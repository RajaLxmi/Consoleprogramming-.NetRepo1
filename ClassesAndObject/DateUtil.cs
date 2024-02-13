
    



//static class 
 static class DateUtil
    {
     public static DateTime presentdate()
    {
        return DateTime.Now;
    }

    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }
    public static int YearOfBirth(DateTime DateOfBirth)
    {
        Console.WriteLine("print year of given date :" + DateOfBirth.Year);
        return DateTime.Now.Year - DateOfBirth.Year;
    }

}

