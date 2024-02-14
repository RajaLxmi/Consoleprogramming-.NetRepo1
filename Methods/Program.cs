// prototype - Define the function (type, name and parameters)
//definition - Has the code. It contains the code block.
//Function call - Makes the function executes.
/*
Why we use functions/methods - when we want to write same code many times then we will write a methods and then we just call that method.
*/
//Void functions - complete the task and doesn't returns a result

void PrintName()
{
    Console.WriteLine("DEMO TEST");
}

string returnDefaultName()
{
    return "Name1 Name2";
}

PrintName();

void Addition( int num1, int num2)
{
    Console.WriteLine($"the sum of {num1} and {num2} is {num1+num2}");
}
Console.WriteLine("Enter number 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine()); 
 Addition(number1, number2);


//value returning functions - complete the task, returns a result

Console.WriteLine("Enter number 3 : ");
int number3 = Convert.ToInt32(Console.ReadLine());

int LargestNumber(int num1, int num2,int num3)
{
    int Largest = num1;
    if(Largest < num2)
    {
        Largest = num2;
    }
    if (Largest < num3)
    {
        Largest = num3;
    }
    return Largest; 
}

int result = LargestNumber(number1,number2,number3);
Console.WriteLine($"Largest number of {number1},{number2} and {number3} is  :  {result}");


