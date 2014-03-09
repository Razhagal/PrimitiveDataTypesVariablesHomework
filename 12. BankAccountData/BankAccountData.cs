using System;
class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Client first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Client middle name");
        string middleName = Console.ReadLine();

        Console.WriteLine("Client last name");
        string lastName = Console.ReadLine();

        Console.WriteLine("Balance:");
        long balance = long.Parse(Console.ReadLine());

        Console.WriteLine("Bank name:");
        string bankName = Console.ReadLine();

        Console.WriteLine("IBAN:");
        string iban = Console.ReadLine();

        Console.WriteLine("Credit card one:");
        string cardOne = Console.ReadLine();

        Console.WriteLine("Credit card two:");
        string cardTwo = Console.ReadLine();

        Console.WriteLine("Credit card three:");
        string cardThree = Console.ReadLine();
    }
}