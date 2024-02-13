
/*
 * Array is a Fixed Collection Type.
 */

// declare Fixed Sized Array

int[] grades = new int[5];

// Add Values to Fixed Size Array

//grades[0] = 10;
//grades[1] = 20;
//grades[2] = 30;
//grades[3] = 40;
//grades[4] = 50;

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Enter Grade : {i}");
    grades[i]= Convert.ToInt32(Console.ReadLine());
}

//Print Values in Fixed Size Array

Console.WriteLine("Printing all grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Grade  {i} is : {grades[i]}");
}