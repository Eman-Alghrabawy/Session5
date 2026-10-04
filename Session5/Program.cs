using System.Drawing;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session5
{
    //enum WeekDays
    //{
    //   Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //   Saturday,
    //    Sunday
    //}
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}
    //[Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    internal class Program
    {
        //static void ChangeValue(int x)
        //{
        //    x = 100;
        //}
        //static void ChangeValue(ref int x)
        //{
        //    x = 100;
        //}

        static void Main(string[] args)
        {
            //            Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.

            //Passing by Value
            //int number = 10;

            //ChangeValue(number);

            //Console.WriteLine(number);

            //Passing by Reference
            //int number = 10;

            //ChangeValue(ref number);

            //Console.WriteLine(number);

            //---------------------------------------------------------------------------------------------------------------------------------------------
            //Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            //            نقدر نعدل الـ object نفسهby value
            //لكن لا نغير الـ reference الأصلي ليشير إلى object جديد.by reference

            //---------------------------------------------------------------------------------------------------------------------------------------------


            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


            //static void Calculate(int num1, int num2, int num3, int num4,
            //            out int sum, out int subtract)
            //{
            //    sum = num1 + num2 + num3 + num4;
            //    subtract = num1 - num2 - num3 - num4;
            //}
            //Console.Write("Enter first number: ");
            //int n1 = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter second number: ");
            //int n2 = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter third number: ");
            //int n3 = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter fourth number: ");
            //int n4 = int.Parse(Console.ReadLine()!);

            //Calculate(n1, n2, n3, n4, out int sum, out int subtract);

            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Subtraction = " + subtract);
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.v
            //        Output should be like
            //        Enter a number: 25
            //        The sum of the digits of the number 25 is: 7


            //static int SumDigits(int number)
            //{
            //    int sum = 0;

            //    while (number != 0)
            //    {
            //        int digit = number % 10;
            //        sum += digit;
            //        number /= 10;
            //    }

            //    return sum;
            //}


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine()!);

            //int result = SumDigits(number);

            //Console.WriteLine("The sum of the digits of the number "
            //                  + number + " is: " + result);
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:




            //static bool IsPrime(int number)
            //{
            //    if (number < 2)
            //        return false;

            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            //}

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine()!);

            //Console.WriteLine(IsPrime(number));
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    min = arr[0];
            //    max = arr[0];

            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min)
            //            min = arr[i];

            //        if (arr[i] > max)
            //            max = arr[i];
            //    }
            //}
            //int[] arr = { 7, 2, 9, 4, 1 };

            //int min = 0;
            //int max = 0;

            //MinMaxArray(arr, ref min, ref max);

            //Console.WriteLine("Min = " + min);
            //Console.WriteLine("Max = " + max);
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //Create an iterative(non - recursive) function to calculate the factorial of the number specified as parameter

            //static int Factorial(int number)
            //{
            //    int result = 1;

            //    for (int i = 1; i <= number; i++)
            //    {
            //        result *= i;
            //    }

            //    return result;
            //}

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine()!);

            //Console.WriteLine("Factorial = " + Factorial(number));
            //---------------------------------------------------------------------------------------------------------------------------------------------



            //Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //static string ChangeChar(string text, int position, char newChar)
            //{
            //    char[] chars = text.ToCharArray();

            //    chars[position] = newChar;

            //    return new string(chars);
            //}


            //Console.Write("Enter string: ");
            //string text = Console.ReadLine()!;

            //Console.Write("Enter position: ");
            //int position = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter new character: ");
            //char newChar = char.Parse(Console.ReadLine()!);

            //string result = ChangeChar(text, position, newChar);

            //Console.WriteLine(result);
            //---------------------------------------------------------------------------------------------------------------------------------------------




            //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.


            // foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //---------------------------------------------------------------------------------------------------------------------------------------------

            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];

            //people[0] = new Person { Name = "Eman", Age = 23 };
            //people[1] = new Person { Name = "Ahmed", Age = 25 };
            //people[2] = new Person { Name = "Mona", Age = 22 };

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("Name: " + people[i].Name);
            //    Console.WriteLine("Age: " + people[i].Age);
            //}
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Enter season: ");
            //string input = Console.ReadLine()!;

            //Season season = (Season)Enum.Parse(typeof(Season), input, true);

            //if (season == Season.Spring)
            //    Console.WriteLine("March to May");
            //else if (season == Season.Summer)
            //    Console.WriteLine("June to August");
            //else if (season == Season.Autumn)
            //    Console.WriteLine("September to November");
            //else if (season == Season.Winter)
            //    Console.WriteLine("December to February");
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //    4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Permissions permissions = Permissions.None;

            //// Add permissions
            //permissions |= Permissions.Read;
            //permissions |= Permissions.Write;

            //// Check permission
            //if ((permissions & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("Read permission exists");

            //// Remove permission
            //permissions &= ~Permissions.Write;

            //if ((permissions & Permissions.Write) == Permissions.Write)
            //    Console.WriteLine("Write permission exists");
            //else
            //    Console.WriteLine("Write permission does not exist");
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //5. Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.Write("Enter color: ");
            //string input = Console.ReadLine()!;

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine(color + " is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine("This is not a primary color.");
            //}
            //---------------------------------------------------------------------------------------------------------------------------------------------


            //7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Point p1 = new Point();
            Point p2 = new Point();

            Console.Write("Enter X1: ");
            p1.X = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Y1: ");
            p1.Y = double.Parse(Console.ReadLine()!);

            Console.Write("Enter X2: ");
            p2.X = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Y2: ");
            p2.Y = double.Parse(Console.ReadLine()!);

            double distance = Math.Sqrt(
                Math.Pow(p2.X - p1.X, 2) +
                Math.Pow(p2.Y - p1.Y, 2)
            );

            Console.WriteLine("Distance = " + distance);

        }
    }
}
