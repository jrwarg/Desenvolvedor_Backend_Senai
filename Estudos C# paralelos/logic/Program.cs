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
// Calling a Method in the same class
/* using System;

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
            return new string (letters);
        }
    }
} */
// Calling a Method outside the class
/* using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }

    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
} */
// Calling a Method from a different Namespace:

/* using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
} */
// Anotations added by "Using" notation:
/* using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
} */

// Deleting / Supressing code blocks => only one line of code

/* bool flag = true;
if (flag) Console.WriteLine(flag);

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck"); */

/* string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck"); */

// Exercise -> reediting the code:

/* int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

if (numbers.Contains(42)) Console.WriteLine("Set contains 42");

foreach (int number in numbers)
{
    total += number;
}
Console.WriteLine($"Total: {total}"); */

// BRANCH THE FLOW OF CODE USING THE SWITCH CASE CONSTRUCT

/* int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}"); */

// SKU = Stock Keeping Unit
/* string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}"); */

// ITERATE THROUGH A CODE BLOCK USING FOR STATEMENT
/* Console.WriteLine("Quantas iterações? : ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    Console.Write(" " + i);
}
Console.Write("\n");
for (int i = 10; i > 0; i--)
{
    Console.Write(" " + i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{ 
    Console.WriteLine(i);
    if (i == 7) break;
}
 */
/* string [] names = {"Alex", "Eddie", "David", "Michel"};
/* for (int i = names.Length - 1; i >= 0; i --)
{
    Console.WriteLine(names[i]);
} */
/* for (int i = 0; i < names.Length; i++)
{
    if(names[i] == "Eddie") names[i] = "Sammy";
}
foreach (var name in names) Console.WriteLine(name); */ 
// Exercise FizzBuzz

/* for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    } else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else {
        Console.WriteLine(i);   
    }
} */
/* 
Random randomic = new Random();
int current = randomic.Next(1, 11);

/* do
{
number = randomic.Next(1, 11);
Console.WriteLine(number);
} while (number != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = randomic.Next(1, 11);
}
Console.WriteLine($"Last number: { current }");

 */
/* Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/
// EXERCISE - GAME = Neu código ficou maior e menos "elegante", mas funcionou....rss....Melhorar...
int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();
int attack = random.Next(1, 11);

while ( heroHealth > 0 || monsterHealth > 0)
{
    Console.WriteLine($"Monster was damaged and lost {attack} health, and now has {monsterHealth} health");
    
    if (monsterHealth <=0)
    {
        Console.WriteLine("Hero wins!");
        break;
    } 
    heroHealth -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health, and now has {heroHealth} health");

    if (heroHealth <=0) 
    {
        Console.WriteLine("Monster wins!");
        break;
    } 
}

/* int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!"); */



