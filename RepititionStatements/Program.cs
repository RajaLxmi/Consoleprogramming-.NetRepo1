// for loop ( counter controllled loop)

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine("counter value : " + i );
}
Console.WriteLine();
Console.WriteLine("for loop finished");

//while loop (condition controled loop - pre check)
int n = 10;
Console.WriteLine(" While loop starts");
while (n < 5)
{
    Console.WriteLine("Input a number : ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"you entered : {n}"); 


}
Console.WriteLine();
Console.WriteLine("WHILE LOOP FINISHED");
//do while loop (condition controled loop - post check)
int n1 = 10;
do
{
    Console.WriteLine("Input a number : ");
    n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"you entered : {n1}");

} while (n1 < 5);


//for each - Honourable Mention

