// See https://aka.ms/new-console-template for more information
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

string permission = "Admin|Manager";
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


