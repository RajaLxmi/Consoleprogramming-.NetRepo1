// See https://aka.ms/new-console-template for more information



//If statement (== ,> , < , >= , <= , !=)
using System.Diagnostics.CodeAnalysis;

int numberofApples = Convert.ToInt32(Console.ReadLine()); ;
int numberofOrange = Convert.ToInt32(Console.ReadLine()); ;

if(numberofApples > numberofOrange)
{
    Console.WriteLine("more number of apples");
}
else if (numberofApples < numberofOrange)
{
    Console.WriteLine("more number of oranges");
}
else if (numberofApples == numberofOrange)
{
    Console.WriteLine("same number of apples and oranges");
}
//Switch statement

int grade = Convert.ToInt32( Console.ReadLine());

switch (grade)
{
    case int n when n < 60:
        Console.WriteLine("fail");
        break;
        case int n when n >= 60 && n<=70:
        Console.WriteLine("second class");
        break;
        case int n when n >= 70 && n<=100:
        Console.WriteLine("first class");
        break;
    default: 
        Console.WriteLine(" not valid");
        break;
        }

//Ternary Operator

var message = numberofApples > numberofOrange ? "more number of apples" : "more number of oranges";
Console.WriteLine(message);

