/*
 * Error itself is an exception and in the way we built with is what we called is handling.
 * The most common way to handle exceptions in C# is by using the try-catch block. 
 * The try block contains the code that might raise an exception, and the catch block catches and handles the exception if it occurs.
 * try
 * catch
 * finally = whether the try or catch block successfult, do this
 * throw = end program execution with the error.
 */

Console.WriteLine("Enter first number :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number :");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    int quotient = num1 / num2;
    Console.WriteLine($" result is : {quotient}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Illegal operation :" + ex.Message );
}

finally
{
    Console.WriteLine(" This is finally block ");
}