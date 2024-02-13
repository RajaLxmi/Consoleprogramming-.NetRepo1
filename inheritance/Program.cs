


Console.WriteLine("Enter  height");
int H = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter  length");
int L = Convert.ToInt32(Console.ReadLine());

Cube cube = new Cube(H,L);
Triangle triangle = new Triangle(H, L);
Rectangle rectangle = new Rectangle(H, L);

Console.WriteLine("cube area is " + cube.getArea());
Console.WriteLine("triangle area is " + triangle.getArea());
Console.WriteLine("rectangle area is " + rectangle.getArea());

