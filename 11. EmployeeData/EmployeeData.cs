using System;
class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Employee First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Employee Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Employee age:");
        string inputAge = Console.ReadLine();
        byte age;
        while (!byte.TryParse(inputAge, out age))
        {
            Console.WriteLine("Invalid input. Enter employee age:");
            inputAge = Console.ReadLine();
        }
        while (age < 0 && age > 100)
        {
            Console.WriteLine("Employee age must be between 0 and 100. Enter the correct value");
            age = byte.Parse(Console.ReadLine());
        }

        Console.WriteLine("Employee gender (m or f):");
        string gender = Console.ReadLine();
        while (gender != "m" && gender != "f")
        {
            Console.WriteLine("Wrong input. Enter employee gender (m or f):");
            gender = Console.ReadLine();
        }

        Console.WriteLine("Employee personal ID number:");
        string inputID = Console.ReadLine();
        ulong idNum;
        while (!ulong.TryParse(inputID, out idNum))
        {
            Console.WriteLine("Invalid input. Enter employee personal ID number:");
            inputID = Console.ReadLine();
        }

        Console.WriteLine("Unique employee number:");
        string inputUniqueNum = Console.ReadLine();
        int uniqueNum;
        while (!int.TryParse(inputUniqueNum, out uniqueNum))
        {
            Console.WriteLine("Invalid input. Enter unique employee number:");
            inputUniqueNum = Console.ReadLine();
        }
        while (uniqueNum < 27560000 && uniqueNum > 27569999)
        {
            Console.WriteLine("Input out of range. Unique employee number must be a number from 27560000 and 27569999.");
            uniqueNum = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Pesonal ID number: " + idNum);
        Console.WriteLine("Unique employee number: " + uniqueNum);
    }
}

