/* string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); */

// ternary conditional operator

/* int saleAmount = 1000;
//int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); */

// Exercise : Heads or Tails?
/* Random coin = new Random();
//int result = coin.Next(0, 2); 
Console.WriteLine((coin.Next(0,2) == 0) ? "heads" : "tails"); */

/* string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else 
{
    Console.WriteLine("You do not have sufficient privileges");
}
 */

 // ======= CONTROL VARIABLE SCOPE AND LOGIC USING CODE BLOCKS ==========

/*  bool flag = true;
 if (flag)
 { 
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
 } */

/*  bool flag = true;
 if (flag)
 {
    int value = 10;
    Console.WriteLine("Inside of code block: " + value);
 }
 Console.WriteLine($"Outside of code block: {value}"); // error CS0103: The name 'value' does not exist in the current context */

/* bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value); // error CS0165: Use of unassigned local variable 'value' */

/* bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value); */

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}


