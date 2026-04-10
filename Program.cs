
string name = "Mr Cookie Monster";
int age = 30;
string address = "1122 Sesame Street";

Console.WriteLine($"{name}, {age}, {address}");



Console.WriteLine("Lets add two numbers");
Console.WriteLine("Please provide the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please provide the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = firstNumber + secondNumber;
Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {thirdNumber}");



Console.WriteLine("Let's divide two numbers and find the remainder.");
Console.WriteLine("Please provide the first number");
int fourthNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please provide the second number");
int fifthNumber = Convert.ToInt32(Console.ReadLine());
int quotient = fourthNumber / fifthNumber;
int remainder = fourthNumber % fifthNumber;
Console.WriteLine($"{fourthNumber} divided by {fifthNumber} equals {quotient}. \t\n The remainder of {fourthNumber} divided by {fifthNumber} is {remainder}");
