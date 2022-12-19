/* Learning exercises of Training series from Microsoft Learn */
/* Console.WriteLine("Hello World!");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code!"); */

/* Console.WriteLine("This is the first line.");
Console.Write("This is ");
Console.Write("the second line."); */

/* Literais 
Console.WriteLine('b');
// Console.WriteLine('Hello World!'); // Too many chars
Console.WriteLine(123);
Console.WriteLine(12.30m);
Console.WriteLine(true);
Console.WriteLine(false);
Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);
*/
/* Variáveis */
/* string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName); */

/* // Variáveis do tipo implícito //
var message = "Hello World!"; */

/* string name = "Bob";
int messages = 3;
double deg = 34.4;

Console.WriteLine($"Hello, {name} You have {messages} messages in your inbox. The temperature is {deg} celsius."); */

/*  Characteres Escape sequences and Verbatim Strings  
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!");

Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// Kon'nichiwa World
Console.WriteLine("\n\n\u3053\u3093\u306B\u3061\u306F World!");


/* Console.WriteLine(@" c:\source\repos 
    (""this is where your code goes"")"); */

/* String concatenation 
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

/* String interpolation 
Console.WriteLine($"{greeting} {firstName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
Console.WriteLine($"C:\\Output\\{projectName}\\Data");*/

// Exercise
/* string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n"); */

// Exercise - Operators //
/* int fahreinheit = 94;
decimal celsius = (fahreinheit - 32m) * (5m/9m);
Console.Write($"The temperature is {celsius} Celsius."); */

// Classes, instances and static methods //
// Each new instance of the class gets its own copy of those fields in which to store state.
// when you need to call stateful methods, you must first create AN INSTANCE of the class so that the method can access state.
// An Instance = OBJECT 
/* Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll); */

/* Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}"); */

// Exercise //
/* int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue); */

// STATEMENT IF //

//Random dice = new Random();

/* int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("You rolled triples! +6 bonus to total");
    total += 6;
}

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    Console.WriteLine("You rolled doubles! + 2 bonus to total!");
    total += 2;
}

if (total >= 15){
    Console.WriteLine("You win!!");
}
else {
    Console.WriteLine("Sorry, you lose.");
}; */

/* string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
*/
/* int roll1 = 6;
int roll2 = 6;
int roll3 = 5;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total > 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else 
{
    Console.WriteLine("You win a kitten");
} */

// Exercise //
/* Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
if (daysUntilExpiration < 1) {
    Console.WriteLine("Your subscription has expired!");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} */

// ARRAYS //
/*string [] fraudulentOrderIDs = new string[3];

 fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789"; */
/* string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

string[] names = {"Bob", "Conrad", "Grant"};
foreach (string name in names)
{
    Console.WriteLine(name);
}
 */
/* 
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory"); */

// Exercise //
/* string[] fakeOrdersIDs = {"B123", "C234", "D345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string items in fakeOrdersIDs)
{
    if (items.StartsWith("B"))
    {
        Console.WriteLine(items);
    }
} */

/* Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, padd with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

 */























