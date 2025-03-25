/* Return Adress
Console.WriteLine("Enter your name");
string? userName = Console.ReadLine();

Console.WriteLine("Enter your Street");
string? streetNumber = Console.ReadLine();

Console.WriteLine("Enter your Zip Code");
string? postCode = Console.ReadLine();

Console.WriteLine($"{userName} | {streetNumber} | {postCode}");
*/

/*Student Information
string? studentName = Console.ReadLine();
int? studentId = Convert.ToInt32(Console.ReadLine());
int? studentAge = Convert.ToInt32(Console.ReadLine());
string? studentSubject = Console.ReadLine();
string? studentUniversity = Console.ReadLine();
*/

/* hex to decimal
string hexValues = "0xFE";
int value = Convert.ToInt32(hexValues, 16);

Console.WriteLine(value);
*/

/* Boolean converter
bool decision = Convert.ToBoolean(Console.ReadLine());

if (!decision)
    Console.WriteLine("This is not true");
else Console.WriteLine("This is true");
*/

/* Variable Switch
int a = 5;
int b = 10;
Console.WriteLine($"BEFORE: Value a: {a}, Value b: {b}");

int c = b;
b = a;
a = c;
Console.WriteLine($"AFTER: Value a: {a}, Value b: {b}");
*/

/*loop
Console.WriteLine("Enter width");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < width; i++)
{
    for (int j = 0; j < number - i; j++)
    {
        Console.Write(number);
    }
    Console.WriteLine();
}
*/

/*Datatypes
int age = 29;
decimal height = 1.85m;
bool hasExperience = true;
char initalLetter = 'M';
string name = "Martin Henle";

Console.WriteLine($"{name}, {age}, {hasExperience}, {initalLetter}, {height}");
*/

/*
int signInCounter = 0;
string dataBaseUserName = "TestUser";
string dataBasePassword = "TestPassword";

while (signInCounter < 3)
{
    Console.WriteLine("Enter User Name");
    string userName = Console.ReadLine();
    Console.WriteLine("Enter Password");
    string password = Console.ReadLine();

    if (userName == dataBaseUserName && password == dataBasePassword)
    {
        Console.WriteLine("Sign in Successful.");
        return; // Beendet das Programm bei erfolgreicher Anmeldung
    }
    else
    {
        signInCounter++;
        Console.WriteLine($"Wrong username or password. You have {3 - signInCounter} tries left.");
    }
}

if (signInCounter == 3)
{
    Console.WriteLine("Login failed. You have no more attempts.");
}
*/

int userInput = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userInput; i++)
{
    // Leerzeichen am Anfang
    for (int space = 1; space <= userInput - i; space++)
    {
        Console.Write(" ");
    }

    // Aufsteigende Zahlen
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }

    // Absteigende Zahlen
    for (int k = i - 1; k >= 1; k--)
    {
        Console.Write(k);
    }

    Console.WriteLine();
}
