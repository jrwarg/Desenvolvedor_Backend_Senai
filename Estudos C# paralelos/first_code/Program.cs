/* int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}"); 

double third = 398.0/ 1234.0;
Console.WriteLine(third);
double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);*/

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

// Calculates the area of a circle => radius is 2.5cm
double PI = 3.14;
double r = 2.5;
Console.WriteLine($"The area is: {(PI * (r*r))}");

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
