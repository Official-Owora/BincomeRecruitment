// Task 1: Declare and initialize variables
string name = "John Doe";
int age = 25;
bool isAdmin = true;

// Print the values of the variables to the console
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Is Admin: " + isAdmin);

// Task 2: Determine if a number is even or odd
Console.Write("Enter an integer: ");
int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

// Task 3: Print numbers 1 to 10 using a for loop
Console.WriteLine("Numbers from 1 to 10:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Task 4: Sum and print elements of an integer array
int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;
Console.WriteLine("Array elements:");
foreach (int num in numbers)
{
    Console.WriteLine(num);
    sum += num;
}
Console.WriteLine("Sum of array elements: " + sum);

// Task 5: Call the Greet method
Greet("Alice");

// To keep the console window open
Console.ReadLine();
// Task 5: Method to print a personalized greeting
static void Greet(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}
