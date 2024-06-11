// Console Output
Console.WriteLine("Hello, World!");

// Console Input
// Console.ReadLine();

// Variables and DataTypes
int age = 32;
string name = "Abdul Rehman Kalsekar";
bool isDeveloper = true;
double efficiency = 90.40D;
float years = 20.2F;

Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isDeveloper);

// TypeCasting
// 1. Implicit
/*
 Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double
 */
int n = 34;
double n2 = n;
Console.WriteLine(n);
Console.WriteLine(n2);

// 2. Explicit 
/*
 Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
 */
Console.WriteLine("My Name is " + name + " My age is " + Convert.ToString(age));

// Operators
int n1 = 20;
n2 = 10;

// Arithematic Operators
Console.WriteLine(n1 + n2);
Console.WriteLine(n1 - n2);
Console.WriteLine(n1 / n2);
Console.WriteLine(n1 * n2);
Console.WriteLine(n1 % n2);

// Assignment Operator
int n3 = 10;
n3 *= 23;
Console.WriteLine(n3 += 10);

// Logical Operator
Console.WriteLine(true && true);
Console.WriteLine(true || true);
Console.WriteLine(true != false);

// Comparision Operator
Console.WriteLine(n1 == n2);
Console.WriteLine(n1 != n2);
Console.WriteLine(n1 >= n2);
Console.WriteLine(n1 <= n2);

// Math Class
Console.WriteLine(Math.Max(n1, n2));
Console.WriteLine(Math.Min(n1, n2));
Console.WriteLine(Math.Abs(n1));

// Conditionals
if (isDeveloper)
{
    Console.WriteLine("Welcome !! You are a Developer");
}
else if (name == "Abdul Rehman")
{
    Console.WriteLine("Welcome !! Abdul Rehman");
}
else
{
    Console.WriteLine("You are not a Developer");
}

// Loops
// There are Three Loops in C Sharp ie for, for each and while.
// Note : There is no Do While Loop in C Sharp

// 1. For Loop
for (int i = 1; i<=10; i++) {
    Console.WriteLine(i);
}

// 2. For EachLoop


// 3. While Loop
/* int j = 0;
while (name[j] != '\0')
{
    Console.Write(name[j]);
    j++;
} */

// Switch Case
// int weekNo = Convert.ToInt32(Console.ReadLine());
int weekNo = 2;
switch (weekNo)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;

    case 5:
        Console.WriteLine("Friday");
        break;
        
    case 6:
        Console.WriteLine("Saturday");
        break;
        
    case 7:
        Console.WriteLine("Sunday");
        break;

    default:
        Console.WriteLine("Invalid Day");
        break;
}

// String 
string str = "Abdul Rehman is a Great Developer";

// String Properties
Console.WriteLine(str.Length);

// String Funcitons / Method
Console.WriteLine(str.ToUpper());
Console.WriteLine(str.ToLower());
Console.WriteLine(str.IndexOf("is"));

// String Interpolation
string myName = "Abdul Rehman";
string greet = $"{myName} is a developer";
Console.WriteLine(greet);

// Escape Sequence 
Console.WriteLine("My name is \"Abdul Rehman\"");
