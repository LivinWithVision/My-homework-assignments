// 1.2.1

string? shouldContinue = "yes";

do
{
    Console.Clear();
    Console.WriteLine("Let's see if two numbers are equal.");
    Console.WriteLine("Please enter the first number");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter a second number");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber == secondNumber)
    {
        Console.WriteLine($"{firstNumber} and {secondNumber} are equal");
    }
    else
    {
        Console.WriteLine($"{firstNumber} and {secondNumber} are not equal");
    }
    Console.WriteLine("Would you like to run this program again? Type 'yes' to contine, 'Quit' to end the program.");
    shouldContinue = Console.ReadLine().ToLower();
}
while (shouldContinue == "yes"); 



//1.2.2 I have two different solutions. The second was my original solution but seemed unnecessarily complicated so I then wrote the first.
//1.2.2.1 
int sum = 0;

Console.WriteLine("The first 10 natural numbers are:");
for (int i = 1; i < 11; i++)
{
    Console.Write(i + " ");
    sum += i;
}
Console.WriteLine();
Console.WriteLine($"The Sum is: {sum}");

//1.2.2.2 Original solution, also works but seems unnecessarily complicated
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1; //i starts at 0, add one to count 1-10
}
Console.WriteLine("The first 10 natural number is: ");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
Console.WriteLine();

int sum = 0;
foreach (int num in numbers)
{
    sum += num;
}
Console.WriteLine($"The sum is: {sum}");

//1.2.3

string? shouldContinue = "yes";

do
{
    Console.Clear();
    Console.WriteLine("Let's perform some basic math.");
    Console.WriteLine("Please enter your first number.");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your second number.");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please select the function you wish to perform. \t\n 1 = Addition, 2 = Subtraction, 3 = Multiplication, 4 = Division");
    int function = Convert.ToInt32(Console.ReadLine());
    switch (function)
    {
        case 1:
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            break;
        case 2:
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            break;
        case 3:
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            break;
        case 4:
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            break;
    }
    Console.WriteLine("Would you like to run this program again? Type 'yes' to contine, 'Quit' to end the program.");
    shouldContinue = Console.ReadLine().ToLower();
} while ( shouldContinue != "quit" );

