﻿/* Learning exercises of Training series from Microsoft Learn */
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
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");















