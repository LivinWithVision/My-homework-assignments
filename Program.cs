using assignments_3._2.Circle.cs;

// 3.2.1 Create a 2D array to store integers and print them in matrix format with proper formatting.

int[,] myArray1 = { { 2, 3, 4 }, { 1, 4, 6 } };
for (int i = 0; i < myArray1.GetLength(0); i++)
{
    Console.Write("| ");
    for (int j = 0; j < myArray1.GetLength(1); j++)
    {
        Console.Write(myArray1[i, j] + " | ");
    }
    Console.WriteLine();
}

// 3.2.2 Write a program in C# Sharp for addition of two Matrices of same size.

Console.WriteLine("Imput the size of the square matrix (less than 5).");
int matrixSize = Convert.ToInt32(Console.ReadLine());

int[,] myArray2 = new int[matrixSize, matrixSize];
int[,] myArray3 = new int[matrixSize, matrixSize];

for (int i = 0; i < myArray2.GetLength(0); i++)
{
    for (int j = 0; j < myArray2.GetLength(1); j++)
    {
        Console.WriteLine($"Please enter values for first array, element {i + 1}, {j + 1}");
        myArray2[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < myArray3.GetLength(0); i++)
{
    for (int j = 0; j < myArray3.GetLength(1); j++)
    {
        Console.WriteLine($"Please enter values for second array, element {i + 1}, {j + 1}");
        myArray3[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("The first Matrix is:");
for (int i = 0; i < myArray2.GetLength(0); i++)
{
    for (int j = 0; j < myArray2.GetLength(1); j++)
    {
        Console.Write($"{myArray2[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("The second Matrix is:");
for (int i = 0; i < myArray3.GetLength(0); i++)
{
    for (int j = 0; j < myArray3.GetLength(1); j++)
    {
        Console.Write($"{myArray3[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("The addition of the two martix is");
for (int i = 0; i < myArray2.GetLength(0); i++)
{
    for (int j = 0; j < myArray2.GetLength(1); j++)
    {
        Console.Write($"{myArray2[i, j] + myArray3[i, j]}" + "\t");
    }
    Console.WriteLine();
}

//3.2.3 Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.

//int circle1Radius = 4;
//int circle2Radius = 5;
//double circle1Area = AreaOfCircle(circle1Radius);
//double circle2Area = AreaOfCircle(circle2Radius);
//double differenceInArea = AreaDifference(circle1Area, circle2Area);
//Console.WriteLine($"The difference in area between circle 1 and circle 2 is {differenceInArea}");

//static double AreaOfCircle(int Radius)
//{
//    return (Math.PI * Radius * Radius);
//}
//static double AreaDifference(double circle1Area, double circle2Area)
//{
//    return Math.Abs(circle1Area - circle2Area);
//}

Circle c1 = new Circle();
c1.Radius = 23.2;
Circle c2 = new Circle();
c2.Radius = 12;
Circle c3 = c1 + c2;
double c4 = c1.Area - c2.Area;

Console.WriteLine($"The third circle area is {c3.Area}");
Console.WriteLine($"The difference in area is {c4}");


//3.2.4 Write a function that takes 4 numbers as input to calculate the total and average.

double total, average;
double[] values = new double[4];
Console.WriteLine("Please enter 4 numbers. \n Enter the first number:");
values[0] = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
values[1] = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number:");
values[2] = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the fourth number:");
values[3] = double.Parse(Console.ReadLine());

Results(out total, out average, values);
Console.WriteLine($"The average of {values[0]}, {values[1]}, {values[2]}, {values[3]},  is: {average}");
Console.WriteLine($"The total is: {total}");

static void Results(out double total, out double average, params double[] values)
{
    total = 0;
    foreach (var i in values)
    {
        total = total + i;
    }
    average = total / values.Length;
}

// 3.2.5 Create a function that finds the index of a given item in the array

int[] searchArray1 = { 1, 5, 3 };
int[] searchArray2 = { 9, 8, 3 };
int[] searchArray3 = { 1, 2, 3 };
int searchNumber = 3;
Console.WriteLine(FindTheIndex(searchArray3, searchNumber));

static int FindTheIndex(int[] array, int searchNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchNumber)
        {
            return i;
        }
    }
    return -1;
}
